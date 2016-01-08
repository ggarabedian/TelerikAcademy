var chat = require('./controllers/chat');

chat.init();

chat.registerUser({ username: 'DonchoMinkov', password: '123456q' });
chat.registerUser({ username: 'NikolayKostov', password: '123456q' });

chat.sendMessage({
    from: 'DonchoMinkov',
    to: 'NikolayKostov',
    text: 'Hey, Niki!'
});

chat.sendMessage({
    from: 'NikolayKostov',
    to: 'DonchoMinkov',
    text: 'Hi, Doncho!'
});

chat.sendMessage({
    from: 'NikolayKostov',
    to: 'DonchoMinkov',
    text: 'How are you!'
});

chat.getAllMessages({
    with: 'DonchoMinkov',
    and: 'NikolayKostov'
});
