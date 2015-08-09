/* globals $ */

function solve() {

  return function (selector) {
    var template =
    '<table class="items-table">' +
        '<thead>' +
            '<tr>' +
                '<th>#</th>' +
                '{{#each headers}} <th>{{this}}</th> {{/each}}' +
            '</tr>' +
        '</thead>' +
        '<tbody>' +
            '{{#each items}}' +
                '<tr>' +
                    '<td>{{@index}}</td>' +
                    '<td>{{this.col1}}' +
                    '<td>{{this.col2}}' +
                    '<td>{{this.col3}}' +
                '</tr>' +
            '{{/each}}'
        '</tbody>' +
    '</table>';
    $(selector).html(template);
  };
}

module.exports = solve;
