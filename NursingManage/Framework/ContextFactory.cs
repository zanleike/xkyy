using System;
using Framework.DBHelper;
using Framework.BuildSQLText;
using Framework.Entitys;
using Framework.ExpressionAnaly;

namespace Framework
{
    class ContextFactory
    {
        static object FactoryLocker = new object();

        static ContextFactory _Instance;
        public static ContextFactory Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (FactoryLocker)
                    {
                        if (_Instance == null) _Instance = new ContextFactory();
                    }
                }
                return _Instance;
            }
        }

        public IDbHelper CreateDbHelper(EmDatabaseType dbType, string connStr)
        {
            IDbHelper dbHelper = null;
            switch (dbType)
            {
                case EmDatabaseType.SQLServer:
                    dbHelper = new SQLHelper(connStr);
                    break;
                case EmDatabaseType.SQLite:
                    dbHelper = new SQLiteHelper(connStr);
                    break;
                case EmDatabaseType.Oracle:
                    dbHelper = new OracleHelper(connStr);
                    break;
                case EmDatabaseType.MySQL:
                    dbHelper = new MySqlDbHelper(connStr);
                    break;
                case EmDatabaseType.OleDb:
                    dbHelper = new OleDbHelper(connStr);
                    break;
                default:
                    throw new Exception("创建dbHelper失败,未支持的数据库类型");
            }
            return dbHelper;
        }
        public BuildSQLBase CreateBuildSQL(EmDatabaseType dbType)
        {
            BuildSQLBase buildSql = null;
            switch (dbType)
            {
                case EmDatabaseType.SQLServer:
                    buildSql = new BuildSQLServer();
                    break;
                case EmDatabaseType.SQLite:
                    buildSql = new BuildSQLite();
                    break;
                case EmDatabaseType.Oracle:
                    buildSql = new BuildOracle();
                    break;
                case EmDatabaseType.MySQL:
                    buildSql = new BuildMySql();
                    break;
                case EmDatabaseType.OleDb:
                    buildSql = new BuildOleDb();
                    break;
                default:
                    throw new Exception("创建BuildSQL失败,未支持的数据库类型");
            }
            return buildSql;
        }
        public IEntityAnaly CreateEntityAnaly()
        {
            return new EntityAnalyReflect();
        }
        public IExpressionAnaly CreateExpressionAnaly()
        {
            return new ExprAnalyBase();
        }
    }
}