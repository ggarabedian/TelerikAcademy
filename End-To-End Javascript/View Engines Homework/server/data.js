(function() {
    'use strict';

    let baseUrl = 'http://localhost:3000';

    module.exports = {
        phones: {
            type: 'Phones',
            url: baseUrl + '/phones',
            products: [{ name: 'Samsung Galaxy 5', price: 399},
                       { name: 'HTC One', price: 499},
                       { name: 'iPhone NOT', price: 1999}]
        },
        tablets: {
            type: 'Tablets',
            url: baseUrl + '/tablets',
            products : [{ name: 'Samsung Tab XXL', price: 699},
                        { name: 'Acer Iconia', price: 399},
                        { name: 'iPhone Air Under Pressure', price: 2999}]
        },
        wearables: {
            type: 'Wearables',
            url: baseUrl + '/wearables',
            products : [{ name: 'Samsung Watch', price: 499},
                        { name: 'Very Special Watch', price: 799},
                        { name: 'iRollEx', price: 12999}]
        }
    };
}());
