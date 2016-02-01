module.exports = function(grunt) {
    grunt.initConfig({
        project: {
            app: 'APP'
        },
        connect: {
            options: {
                port: 9578,
                livereload: 53231,
                hostname: 'localhost'
            },
            livereload: {
                options: {
                    open: true,
                    base: [
                        'DEV'
                    ]
                }
            }
        },
        watch: {
            js: {
                files: ['Gruntfile.js', 'DEV/scripts/*.js'],
                tasks: ['jshint'],
                options: {
                    livereload: true
                }
            },
            coffee: {
                files: ['<%= project.app %>/**/*.coffee'],
                tasks: ['coffee'],
                options: {
                    livereload: true
                }
            },
            styles: {
                files: ['<%= project.app %>/**/*.styl'],
                tasks: ['stylus'],
                options: {
                    livereload: true
                }
            },
            jade: {
                files: ['<%= project.app %>/**/*.jade'],
                tasks: ['jade'],
                options: {
                    livereload: true
                }
            },
            html: {
                files: ['DEV/**/*.html'],
                options: {
                    livereload: true
                }
            },
            livereload: {
                options: {
                    livereload: '<%= connect.options.livereload %>'
                },
                files: [
                    'DEV/*.html',
                    'DEV/scripts/*.js',
                    'DEV/styles/*.css'
                ]
            }
        },
        coffee: {
            compile: {
                options: {
                    bare: true
                },
                files: {
                    'DEV/scripts/script.js': 'APP/script.coffee'
                }
            }
        },
        jshint: {
            all: ['Gruntfile.js', 'DEV/scripts/**/*.js']
        },
        stylus: {
            compile: {
                options: {
                    compress: false
                },
                files: {
                    'DEV/styles/site.css': 'APP/site.styl'
                }
            }
        },
        jade: {
            compile: {
                options: {
                    pretty: true
                },
                files: {
                    'DEV/home.html': 'APP/home.jade'
                }
            }
        },
        copy: {
            main: {
                files: [{
                    expand: true,
                    cwd: 'APP/images',
                    src: '**/*',
                    dest: 'DEV/images'
                }, {
                    expand: true,
                    cwd: 'APP/images',
                    src: '**/*',
                    dest: 'DIST/images'
                }]
            }
        },
        csslint: {
            app: ['DEV/styles/*.css']
        },
        concat: {
            js: {
                files: {
                    'DIST/scripts/all.js': ['DEV/scripts/**/*.js']
                }
            },
            css: {
                files: {
                    'DIST/styles/all.css': ['DEV/styles/**/*.css']
                }
            }
        },
        uglify: {
            js: {
                files: {
                    'DIST/scripts/all.min.js': 'DIST/scripts/all.js'
                }
            }
        },
        cssmin: {
            css: {
                files: {
                    'DIST/styles/all.min.css': 'DIST/styles/all.css'
                }
            }
        },
        htmlmin: {
            dist: {
                options: {
                    collapseWhitespace: true
                },
                files: {
                    'DIST/home.html': 'DEV/home.html'
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-coffee');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-stylus');
    grunt.loadNpmTasks('grunt-contrib-jade');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-connect');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-csslint');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-htmlmin');

    grunt.registerTask('serve', ['coffee', 'jshint', 'stylus', 'jade', 'copy', 'connect', 'watch']);
    grunt.registerTask('build', ['coffee', 'jshint', 'stylus', 'jade', 'csslint', 'concat', 'uglify', 'cssmin', 'htmlmin', 'copy']);
};
