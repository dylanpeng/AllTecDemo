/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50711
Source Host           : 127.0.0.1:3306
Source Database       : test

Target Server Type    : MYSQL
Target Server Version : 50711
File Encoding         : 65001

Date: 2017-02-09 20:19:30
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for provice
-- ----------------------------
DROP TABLE IF EXISTS `provice`;
CREATE TABLE `provice` (
  `ProviceId` int(11) NOT NULL AUTO_INCREMENT,
  `ProviceName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ProviceId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
