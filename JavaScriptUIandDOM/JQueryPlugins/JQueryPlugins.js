function solve() {
    return function(selector) {
        var $dropdown = $('<div />').addClass('dropdown-list');
        var $select = $(selector)
                    .hide()
                    .appendTo($dropdown);

        var $currentOption = $('<div />')
                        .addClass('current')
                        .text('Select a value')
                        .appendTo($dropdown);

        var $optionsContainer = $('<div />')
                .addClass('options-container')
                .css('position', 'absolute')
                .hide()
                .appendTo($dropdown);

        $select.find('option').each(function(index){
            var $this = $(this);

            $('<div />')
                .appendTo($optionsContainer)
                .addClass('dropdown-item')
                .attr('data-value', $this.val())
                .attr('data-index', index)
                .text($this.text())
                .click(function(){
                    $currentOption.val($this.val());
                    $currentOption.text($this.text());
                    $optionsContainer.hide();

                    $select.val($this.val());
                })

        });

        $currentOption.click(function(){
            $optionsContainer.toggle();
            $currentOption.text('Select a value');
        })

        $('body').append($dropdown);
    };
}

module.exports = solve;
