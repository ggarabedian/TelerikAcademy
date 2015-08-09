/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [],
			categories = [];

		function listBooks(arg) {
			var listByAuthor = [], 
				i,
				len;

		    if(arguments.length > 0) {	        
		        if(typeof arg.author !== 'undefined') {

		            for(i = 0, len = books.length; i < len; i += 1) {
		                if(books[i].author === arg.author) {
		                    listByAuthor.push(books[i]);
		                }
		            }

		            return listByAuthor;
		        }

			    if(typeof arg.category !== 'undefined') {

			            return typeof categories[arg.category] !== 'undefined' ?
			                categories[arg.category].books : [];
			    }
			}

		    return books;
		}

		function addBook(book) {
			book.ID = books.length + 1;

			// validateBook(book, 5);

			isUnique(book.title, 'title');
			isUnique(book.isbn, 'isbn');

			validateTitleAndCategory(book.title);
			validateTitleAndCategory(book.category);
			validateAuthor(book.author);
			validateIsbn(book.isbn);

			if(categories.indexOf(book.category) < 0){
				addCategory(book.category);
			}

			categories[book.category].books.push(book);

			books.push(book);

			return book;
		}

		function listCategories(category) {

		    var categoriesNames = [];
		    Array.prototype.push.apply(categoriesNames, Object.keys(categories));

		    return categoriesNames;
		}

		function addCategory(category){
			categories[category] = {
				books: [],
				ID: categories.length + 1
			};
		}

		function validateBook(book, argsCount){
			if(Object.keys(book).length !== argsCount){
				throw new Error('Missing book parameters');
			}

			for (var arg in book) {
				if(typeof book[arg] === 'undefined'){
					throw new Error(arg + 'must be defined');
				}
			}
		}

		function isUnique(propToCheck, propKey){
			var i,
				len;

			for (i = 0, len = books.length; i < len; i += 1){
				if(books[i][propKey] === propToCheck){
					throw new Error(propToCheck + ' already exist as book ' + propKey);
				}
			}
		}

		function validateTitleAndCategory(title){
			if(title === 'undefined' || title === ''){
				throw new Error('Title cannot be undefined or empty string');
			}

			if(title.length < 2 || title.length > 100){
				throw new Error('Title length must be between 2 and 100 characters');
			}
		}

		function validateAuthor(author){
			if(author === '' || author === 'undefined' ){
				throw new Error('Author cannot be undefined or empty string');
			}
		}

		function validateIsbn(isbn){
			if((isbn.length !== 10 && isbn.length !== 13) || !isFinite(isbn)){
				throw new Error('Isbn must be 10 or 13 digits long');
			}
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;