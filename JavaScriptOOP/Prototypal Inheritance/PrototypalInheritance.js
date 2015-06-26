/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
	  * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * // method removeAttribute(attribute)
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	var domElement = (function () {

		function isString(element){
			return typeof element === 'string';
		}

	  function validateTypeName(domElement){
	    if ((!/^[a-zA-Z0-9]+$/.test(domElement)) || (domElement === '') || (!isString(domElement))) {
	      throw new Error('Dom Element name must contain only latin letters or digits.');
	    }
	  }

	  function validateAttributeName(attributeName){
	    if ((!/^[a-zA-Z0-9\-]+$/.test(attributeName)) || (domElement === '')) {
	      throw new Error('Attribute name must contain only latin letters, digits or dashes.');
	    }
	  }

	  var domElement = {

			get type() {
				return this._type;
			},
			set type(value) {
				validateTypeName(value);
				this._type = value;
			},
			get content() {
				return this._content;
			},
			set content(value){
				this._content = value;
			},
			get parent() {
				return this._parent;
			},
			set parent(value){
				this._parent = value;
			},
			get attributes() {
				return this._attributes;
			},
			set attributes(value){
				this._attributes = value;
			},
			get children() {
				return this._children;
			},
			set children(value){
				this._children = value;
			},

	    init: function(type) {
	      this.type = type;
				this.attributes = {};
				this.children = [];
	      this.content;
				this.parent;

	      return this;
	    },

	    appendChild: function(child) {
	      child.parent = this;

	      this.children.push(child);

	      return this;
	    },

	    addAttribute: function(name, value) {
	      validateAttributeName(name);
	      this.attributes[name] = value;

	      return this;
	    },

	    removeAttribute: function(attribute){
	      if(this.attributes[attribute]){
	        delete this.attributes[attribute];
	      } else {
	        throw new Error('The attribute to be removed does not exist!');
	      }

	      return this;
	    },

	    get innerHTML(){
	      var innerHTML = '<' + this.type,
	          keys = Object.keys(this.attributes).sort(),
	          i, iLen,
						j, jLen;

	      if (this.attributes) {
	        for (i = 0, iLen = keys.length; i < iLen; i += 1) {
	          innerHTML += ' ' + keys[i] + '="' + this.attributes[keys[i]] + '"';
	        }
	      }
	      innerHTML += '>';

	      if (this.children.length > 0){
	        this.content = '';

	        for (j = 0, jLen = this.children.length; j < jLen; j += 1) {
	          if (isString(this.children[j])) {
	            innerHTML += this.children[j];
	          } else {
	            innerHTML += this.children[j].innerHTML;
	          }
	        }
	      }

	      if(this.content){
	        innerHTML += this.content;
	      }

	      innerHTML += '</' + this.type + '>';

	      return innerHTML;
	    }
	  };
	  	return domElement;
	} ());
		return domElement;
}
