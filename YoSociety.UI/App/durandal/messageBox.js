define(function() {
    var MessageBox = function(message, title, options) {
        this.message = message;
        this.title =  MessageBox.defaultTitle || title;
        this.options = options || MessageBox.defaultOptions;
    };

    MessageBox.prototype.selectOption = function (dialogResult) {
        this.modal.close(dialogResult);
    };

    MessageBox.defaultTitle = '';
    MessageBox.defaultOptions = ['Ok'];

    return MessageBox;
});