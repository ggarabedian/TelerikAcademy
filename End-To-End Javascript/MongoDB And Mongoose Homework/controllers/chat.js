var UserController,
    MessageController,
    ConnectionString = 'localhost:27017/Chat';

module.exports = {
    init: function() {
        require('../config/mongoose')(ConnectionString);
        userController = require('../controllers/user-controller');
        messageController = require('../controllers/message-Controller');
    },
    registerUser: function(user) {
        userController.registerUser(user);
    },
    sendMessage: function(message) {
        messageController.sendMessage(message);
    },
    getAllMessages: function(messages) {
        messageController.getAllMessages(messages, function(result) {
            console.log(result.join('\n\n'));
        });
    }
}
