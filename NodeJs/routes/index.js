var express = require('express');
var request = require('request');
var router = express.Router();

/* GET home page. */
router.get('/Node/View/UnitTest', function(req, res, next) {
  request('http://localhost:14305/WebService1.asmx/UnitTestResults', function (error, response, body) {
    resp = "baal";
    // console.log('error:', error); // Print the error if one occurred
    // console.log('statusCode:', response && response.statusCode); // Print the response status code if a response was received
    // console.log('body:', body); // Print the HTML for the Google homepage.
    //res.send(body);
    
    body = body.replace(`<?xml version="1.0" encoding="utf-8"?>`, '');
    body = body.replace(`<string xmlns="http://tempuri.org/">`, '');
    body = body.replace(`</string>`, '');
    
    res.render('index', { data: JSON.parse(body) });
  });
});
router.get('/Node/View/ew/cmd/aNonPassing', function(req, res, next) {
  request('http://localhost:14305/WebService1.asmx/UnitTestResults', function (error, response, body) {
    resp = "baal";
    // console.log('error:', error); // Print the error if one occurred
    // console.log('statusCode:', response && response.statusCode); // Print the response status code if a response was received
    // console.log('body:', body); // Print the HTML for the Google homepage.
    //res.send(body);
    
    body = body.replace(`<?xml version="1.0" encoding="utf-8"?>`, '');
    body = body.replace(`<string xmlns="http://tempuri.org/">`, '');
    body = body.replace(`</string>`, '');
    
    res.render('index', { data: JSON.parse(body) });
  });
});

module.exports = router;
