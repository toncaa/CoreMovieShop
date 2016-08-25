/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require("gulp"),
          rimraf = require("rimraf"),
          fs = require("fs"),
          less = require("gulp-less");

var project = require('./project.json');


gulp.task("less", function () {
    return gulp.src('wwwroot/css/my_stylesheet.less')
      .pipe(less())
      .pipe(gulp.dest(project.webroot + '/css'));
});