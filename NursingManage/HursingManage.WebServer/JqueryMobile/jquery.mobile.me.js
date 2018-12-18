// 提示确认框，text：提示文本，callback：点击确认后的回掉函数
function confirmJQM(text, callback) {
    var popupDialogId = 'popupDialogC';
    $('<div data-role="popup" id="' + popupDialogId + '" data-confirmed="no" data-position-to="window" data-transition="pop" data-theme="b" data-dismissible="false" style="max-width:500px;">' +
        '<div role="main" class="ui-content" style="text-align: center;">' +
            '<h3 class="ui-title">' + text + '</h3>' +
            '<p></p>' +
            '<a data-role="button" data-theme="b" class="optionCancel" data-mini="true" data-inline="true" onclick="$(\'#popupDialogC\').popup(\'close\');" >取消</a>' +
            '<a data-role="button" data-theme="b" class="optionConfirm" data-transition="flow" data-inline="true" data-mini="true">确定</a>' +
        '</div>' +
    '</div>').appendTo($.mobile.pageContainer);
    var popupDialogObj = $('#' + popupDialogId);
    popupDialogObj.trigger('create');  //动态加载时 需要重新刷新下 也就是给popup赋上jqm对应的css

    //初始化popup
    popupDialogObj.popup({
        //关闭时 绑定的事件
        afterclose: function (event, ui) {
            popupDialogObj.find(".optionConfirm").first().off('click'); //关闭时 需要清除确定按钮上 绑定的事件
            $(event.target).remove();//删除 创建的 popup
        },

        //显示时 绑定的事件
        afteropen: function (event, ui) {
            popupDialogObj.find(".optionConfirm").first().on('click', function () {
                popupDialogObj.attr('data-confirmed', 'no');
                $('#popupDialogC').popup('close');
                if (callback && callback instanceof Function) {
                    callback();
                }
            });
        }
    });
    //打开
    popupDialogObj.popup('open');
}

//显示加载器  
function showPromptMsg(msg,sec,callBack) {
    //显示加载器.for jQuery Mobile 1.2.0
    $.mobile.loading('show', {
        text: msg, //加载器中显示的文字  
        textVisible: true, //是否显示文字  
        theme: 'b',        //加载器主题样式a-e  
        textonly: true,   //是否只显示文字  
        html: ""           //要显示的html内容，如图片等  
    });
    if (sec == undefined || sec == null) sec == 2;
    setTimeout(function () {
        $.mobile.loading('hide');
        if (callBack != undefined) callBack();
    }, sec * 1000);
   

}


Date.prototype.Format = function (fmt) { //author: meizz 
    var o = {
        "M+": this.getMonth() + 1, //月份 
        "d+": this.getDate(), //日 
        "h+": this.getHours(), //小时 
        "m+": this.getMinutes(), //分 
        "s+": this.getSeconds(), //秒 
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度 
        "S": this.getMilliseconds() //毫秒 
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}