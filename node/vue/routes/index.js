var express = require('express');
var indexcontroller = require('../controllers/indexcontroller');
var router = express.Router();

/* GET home page. */
router.get('/', indexcontroller.homepage);

//getting
router.get('/getting', indexcontroller.getting);

module.exports = router;
