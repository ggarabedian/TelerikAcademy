/*
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
    return function (books) {
    var bestBookCount = 0,
        authorsToPrint = [];
    _.chain(books)
        .map(function(book){
            book.authorFullName = book.author.firstName + " " + book.author.lastName;
            return book;
        })
        .groupBy("authorFullName")
        .each(function(value, key){
              if (value.length >= bestBookCount) {
                  bestBookCount = value.length;
                  authorsToPrint.push(key);
              }
        })
        .value();

        _.chain(authorsToPrint)
            .sortBy(function(name){
                return name;
            })
            .each(function(author){
                console.log(author);
            })
    };
}

module.exports = solve;
