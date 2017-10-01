﻿/// <binding AfterBuild='less' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    less = require('gulp-less'),
    cssmin = require('gulp-cssmin'),
    rename = require('gulp-rename');


gulp.task('watch', function () {
    gulp.watch('wwwroot/css/site.less', ['lessVendor']);
    gulp.watch('wwwroot/css/vendor.less', ['lessSite']);
});

gulp.task('lessSite', function () {
    return gulp.src('ClientApp/less/site.less')
        .pipe(less().on('error', function (err) {
            console.log(err);
        }))
        .pipe(cssmin().on('error', function (err) {
            console.log(err);
        }))
        .pipe(gulp.dest('wwwroot/css/'));
});

gulp.task('lessVendor', function () {
    return gulp.src('ClientApp/less/vendor.less')
        .pipe(less().on('error', function (err) {
            console.log(err);
        }))
        .pipe(cssmin().on('error', function (err) {
            console.log(err);
        }))
        .pipe(gulp.dest('wwwroot/css/'));
});


//gulp.task('less vendor', function () {
//    return gulp.src('ClientApp/less/vendor.less')
//        .pipe(less().on('error', function (err) {
//            console.log(err);
//        }))
//        .pipe(cssmin().on('error', function (err) {
//            console.log(err);
//        }))
//        .pipe(gulp.dest('wwwroot/css/'));
//});

gulp.task('default', ['lessSite', 'lessVendor', 'watch']);