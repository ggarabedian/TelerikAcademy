/* globals $ */

/*

Create a function that takes an id or DOM element and:


*/

function solve() {
    return function(selector) {
        var selector = document.getElementById(selector) || selector;

        var buttons = selector.getElementsByClassName('button'),
            content = selector.getElementsByClassName('content');

        for (var i = 0; i < buttons.length; i++) {
            buttons[i].innerHTML = 'hide';

            buttons[i].addEventListener('click', changeContentDisplay, false)
        }

        function changeContentDisplay(e) {
            var currentTarget = e.target;
            while (true) {
                currentTarget = currentTarget.nextElementSibling;
                if (currentTarget === null || currentTarget.className === 'button') {
                    break;
                }
            }

            currentTarget = currentTarget.previousElementSibling;

            if (currentTarget.style.display == '') {
                currentTarget.style.display = 'none';
                e.target.innerHTML = 'show';
            }
            else if (currentTarget.style.display == 'none') {
                currentTarget.style.display = '';
                e.target.innerHTML = 'hide';
            }
        }
    };
};

module.exports = solve;
