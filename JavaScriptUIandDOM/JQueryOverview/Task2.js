/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string`

*/
function solve() {
    return function(selector) {
        if (typeof(selector) !== 'string' || $(selector).size() === 0) {
            throw new Error();
        }

        var $selector = $(selector);

        var $buttons = $selector.children('.button');

        $buttons.each(doStuff);

        function doStuff(index){
            $this = $(this);
            $this.text('hide');
            $this.click(function(){
                var $buttonThis = $(this);

                if ($buttonThis.nextAll().hasClass('button')) {
                    // $buttonThis.next('.content').toggle();
                    if ($buttonThis.next().css('display') === 'none') {
                        $buttonThis.text('hide');
                        $buttonThis.next().css('display', '');
                    } else {
                        $buttonThis.text('show');
                        $buttonThis.next().css('display', 'none');
                    }
                }
            });
        }
    };
};

module.exports = solve;
