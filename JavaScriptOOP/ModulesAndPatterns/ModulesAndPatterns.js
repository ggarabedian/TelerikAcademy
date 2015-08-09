/* Task Description */
/*
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    function validatePresentations(presentations) {
        var i,
            len = presentations.length,
            currentPresentation;

        if (len === 0) {
            throw new Error('At least one presentation is needed');
        }

        for (i = 0; i < len; i += 1) {
            validateTitle(presentations[i]);
        }
    }

    function validateTitle(title) {
        if (title.match(/(^\s|\s$|\s\s)/) || title === '') {
            throw new Error('Presentation title must not begin or end with space and contain at least one letter');
        }
    }

    function validateName(name) {
        if (!name.match(/^[A-Z]/)) {
            throw new Error('Name must start with capital letter');
        }
    }

    function validateHomework(homeworkID) {
        if (homeworkID < 1 || homeworkID > presentationsCount || homeworkID !== (homeworkID | 0)) {
            throw new Error('Invalid homework ID');
        }
    }

    function validateStudent(studentID) {
        if (studentID < 1 || studentID > studentIds || studentID !== (studentID | 0)) {
            throw new Error('Invalid student ID');
        }
    }

    var Course = {
        init: function(title, presentations) {
            studentIds = 0;
            presentationsCount = presentations.length;

            validateTitle(title);
            validatePresentations(presentations);

            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function(name) {
            var names = name.split(' '),
                firstName = names[0],
                lastName = names[1];
            studentIds += 1;

            if (names.length > 2) {
                throw new Error('Student must have only first and last name');
            }

            validateName(firstName);
            validateName(lastName);

            student = {
                firstname: firstName,
                lastname: lastName,
                id: studentIds,
            }

            this.students.push(student);

            return student.id;
        },
        getAllStudents: function() {
            return this.students.slice(0);
        },
        submitHomework: function(studentID, homeworkID) {
            validateHomework(homeworkID);
            validateStudent(studentID);
        },
        pushExamResults: function(results) {},
        getTopStudents: function() {}
    };

    return Course;
}

module.exports = solve;
