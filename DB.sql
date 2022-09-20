-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        8.0.30 - MySQL Community Server - GPL
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- menu_db 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `menu_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `menu_db`;

-- 테이블 menu_db.menu 구조 내보내기
CREATE TABLE IF NOT EXISTS `menu` (
  `Name_kor` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Name_index` varchar(50) DEFAULT NULL,
  `Price` int DEFAULT NULL,
  `Type` varchar(50) DEFAULT NULL,
  `Image` varchar(50) DEFAULT NULL,
  `IsSoldout` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 menu_db.menu:~123 rows (대략적) 내보내기
DELETE FROM `menu`;
INSERT INTO `menu` (`Name_kor`, `Name_index`, `Price`, `Type`, `Image`, `IsSoldout`) VALUES
	('케이준양념감자 중', 'largefry', 1000, 'pickside', 'ImageDB\\Side_Add\\largefry.png', 0),
	('간장마늘싸이버거', 'buger1', 4400, 'buger', 'ImageDB\\Buger\\buger1.png', 0),
	('갈릭바베큐치킨버거', 'buger2', 5600, 'buger', 'ImageDB\\Buger\\buger2.png', 0),
	('딥치즈버거', 'buger3', 4500, 'buger', 'ImageDB\\Buger\\buger3.png', 0),
	('딥치즈싸이버거', 'buger4', 4800, 'buger', 'ImageDB\\Buger\\buger4.png', 0),
	('불고기버거', 'buger5', 3500, 'buger', 'ImageDB\\Buger\\buger5.png', 0),
	('불싸이버거', 'buger6', 4400, 'buger', 'ImageDB\\Buger\\buger6.png', 0),
	('새우불고기버거', 'buger7', 5100, 'buger', 'ImageDB\\Buger\\buger7.png', 0),
	('쉬립프싸이플렉스버거', 'buger8', 6500, 'buger', 'ImageDB\\Buger\\buger8.png', 0),
	('싸이버거', 'buger9', 4300, 'buger', 'ImageDB\\Buger\\buger9.png', 0),
	('싸이플렉스버거', 'buger10', 7200, 'buger', 'ImageDB\\Buger\\buger10.png', 0),
	('양념치킨싸이버거', 'buger11', 4400, 'buger', 'ImageDB\\Buger\\buger11.png', 0),
	('어메이징매콤마요버거', 'buger12', 5600, 'buger', 'ImageDB\\Buger\\buger12.png', 0),
	('언빌리버블버거', 'buger13', 5600, 'buger', 'ImageDB\\Buger\\buger13.png', 0),
	('에그불고기버거', 'buger14', 4300, 'buger', 'ImageDB\\Buger\\buger14.png', 0),
	('인크레더블버거', 'buger15', 5400, 'buger', 'ImageDB\\Buger\\buger15.png', 0),
	('치즈홀릭버거(에멘탈)', 'buger16', 5600, 'buger', 'ImageDB\\Buger\\buger16.png', 0),
	('치즈홀릭버거(체다)', 'buger17', 5600, 'buger', 'ImageDB\\Buger\\buger17.png', 0),
	('텍사스바베큐치킨버거', 'buger18', 5800, 'buger', 'ImageDB\\Buger\\buger18.png', 0),
	('트리플딥치즈싸이버거', 'buger19', 5100, 'buger', 'ImageDB\\Buger\\buger19.png', 0),
	('할라피뇨통살버거', 'buger20', 4400, 'buger', 'ImageDB\\Buger\\buger20.png', 0),
	('햄치즈휠렛버거', 'buger21', 4600, 'buger', 'ImageDB\\Buger\\buger21.png', 0),
	('화이트갈릭버거', 'buger22', 4600, 'buger', 'ImageDB\\Buger\\buger22.png', 0),
	('휠렛버거', 'buger24', 4100, 'buger', 'ImageDB\\Buger\\buger24.png', 0),
	('간장마늘떡강정', 'chicken1', 12000, 'chicken', 'ImageDB\\Chicken\\chicken1.png', 0),
	('간장마늘싸이순살', 'chicken2', 12900, 'chicken', 'ImageDB\\Chicken\\chicken2.png', 0),
	('간장마늘치킨', 'chicken3', 18900, 'chicken', 'ImageDB\\Chicken\\chicken3.png', 0),
	('군옥수수뿌치', 'chicken4', 18900, 'chicken', 'ImageDB\\Chicken\\chicken4.png', 0),
	('군옥수수뿌치싸이순살', 'chicken5', 12900, 'chicken', 'ImageDB\\Chicken\\chicken5.png', 0),
	('맘스양념싸이순살', 'chicken6', 12900, 'chicken', 'ImageDB\\Chicken\\chicken6.png', 0),
	('맘스양념치킨', 'chicken7', 18900, 'chicken', 'ImageDB\\Chicken\\chicken7.png', 0),
	('반반치킨', 'chicken8', 17900, 'chicken', 'ImageDB\\Chicken\\chicken8.png', 0),
	('치즈뿌치(체다)', 'chicken9', 18900, 'chicken', 'ImageDB\\Chicken\\chicken9.png', 0),
	('치즈뿌치싸이순살(체다)', 'chicken10', 12900, 'chicken', 'ImageDB\\Chicken\\chicken10.png', 0),
	('치즈뿌치텐더', 'chicken11', 9500, 'chicken', 'ImageDB\\Chicken\\chicken11.png', 0),
	('치파오떡강정', 'chicken12', 12000, 'chicken', 'ImageDB\\Chicken\\chicken12.png', 0),
	('치파오싸이순살', 'chicken13', 12900, 'chicken', 'ImageDB\\Chicken\\chicken13.png', 0),
	('케이준떡강정', 'chicken14', 11500, 'chicken', 'ImageDB\\Chicken\\chicken14.png', 0),
	('핫치즈싸이순살', 'chicken15', 13500, 'chicken', 'ImageDB\\Chicken\\chicken15.png', 0),
	('허니버터뿌치', 'chicken16', 18900, 'chicken', 'ImageDB\\Chicken\\chicken16.png', 0),
	('허니뿌치싸이순살', 'chicken17', 12900, 'chicken', 'ImageDB\\Chicken\\chicken17.png', 0),
	('후라이드싸이순살', 'chicken18', 10900, 'chicken', 'ImageDB\\Chicken\\chicken18.png', 0),
	('후라이드치킨', 'chicken19', 16900, 'chicken', 'ImageDB\\Chicken\\chicken19.png', 0),
	('후라이드텐더', 'chicken20', 7500, 'chicken', 'ImageDB\\Chicken\\chicken20.png', 0),
	('후라이드통다리(1조각)', 'chicken21', 4500, 'chicken', 'ImageDB\\Chicken\\chicken21.png', 0),
	('간장마늘싸이버거세트', 'setmenu1', 6700, 'setmenu', 'ImageDB\\SetMenu\\setmenu1.jpg', 0),
	('갈릭바베큐치킨버거세트', 'setmenu2', 7900, 'setmenu', 'ImageDB\\SetMenu\\setmenu2.jpg', 0),
	('공룡키즈세트', 'setmenu3', 5400, 'setmenu', 'ImageDB\\SetMenu\\setmenu3.png', 0),
	('디럭스불고기버거세트', 'setmenu4', 6900, 'setmenu', 'ImageDB\\SetMenu\\setmenu4.jpg', 0),
	('딥치즈버거세트', 'setmenu5', 6800, 'setmenu', 'ImageDB\\SetMenu\\setmenu5.jpg', 0),
	('딥치즈싸이버거세트', 'setmenu6', 7100, 'setmenu', 'ImageDB\\SetMenu\\setmenu6.jpg', 0),
	('불고기버거세트', 'setmenu7', 5800, 'setmenu', 'ImageDB\\SetMenu\\setmenu7.jpg', 0),
	('불싸이버거세트', 'setmenu8', 6700, 'setmenu', 'ImageDB\\SetMenu\\setmenu8.jpg', 0),
	('새우불고기버거세트', 'setmenu9', 7400, 'setmenu', 'ImageDB\\SetMenu\\setmenu9.jpg', 0),
	('쉬림프싸이플렉스버거세트', 'setmenu10', 8800, 'setmenu', 'ImageDB\\SetMenu\\setmenu10.jpg', 0),
	('싱글떡강정세트', 'setmenu11', 8900, 'setmenu', 'ImageDB\\SetMenu\\setmenu11.png', 0),
	('싱글치킨세트', 'setmenu12', 13400, 'setmenu', 'ImageDB\\SetMenu\\setmenu12.png', 0),
	('싱글통다리세트', 'setmenu13', 9900, 'setmenu', 'ImageDB\\SetMenu\\setmenu13.png', 0),
	('싸이버거세트', 'setmenu14', 6600, 'setmenu', 'ImageDB\\SetMenu\\setmenu14.jpg', 0),
	('싸이플렉스버거세트', 'setmenu15', 9500, 'setmenu', 'ImageDB\\SetMenu\\setmenu15.jpg', 0),
	('양념치킨싸이버거세트', 'setmenu16', 6700, 'setmenu', 'ImageDB\\SetMenu\\setmenu16.jpg', 0),
	('어메이징매콤마요버거세트', 'setmenu17', 7900, 'setmenu', 'ImageDB\\SetMenu\\setmenu17.jpg', 0),
	('언빌리버블버거세트', 'setmenu18', 7900, 'setmenu', 'ImageDB\\SetMenu\\setmenu18.jpg', 0),
	('인크레더블버거세트', 'setmenu19', 7700, 'setmenu', 'ImageDB\\SetMenu\\setmenu19.jpg', 0),
	('치즈홀릭버거(에멘탈)세트', 'setmenu20', 7900, 'setmenu', 'ImageDB\\SetMenu\\setmenu20.jpg', 0),
	('치즈홀릭버거(체다)세트', 'setmenu21', 7900, 'setmenu', 'ImageDB\\SetMenu\\setmenu21.jpg', 0),
	('커플떡강정세트', 'setmenu22', 19100, 'setmenu', 'ImageDB\\SetMenu\\setmenu22.png', 0),
	('커플치킨세트', 'setmenu23', 19600, 'setmenu', 'ImageDB\\SetMenu\\setmenu23.png', 0),
	('커플통다리세트', 'setmenu24', 15600, 'setmenu', 'ImageDB\\SetMenu\\setmenu24.png', 0),
	('텍사스바베큐치킨버거세트', 'setmenu25', 8100, 'setmenu', 'ImageDB\\SetMenu\\setmenu25.jpg', 0),
	('통새우버거세트', 'setmenu26', 5400, 'setmenu', 'ImageDB\\SetMenu\\setmenu26.jpg', 0),
	('트리플딥치즈싸이버거세트', 'setmenu27', 7400, 'setmenu', 'ImageDB\\SetMenu\\setmenu27.jpg', 0),
	('할라피뇨통살버거세트', 'setmenu28', 6700, 'setmenu', 'ImageDB\\SetMenu\\setmenu28.jpg', 0),
	('화이트갈릭버거세트', 'setmenu29', 6900, 'setmenu', 'ImageDB\\SetMenu\\setmenu29.jpg', 0),
	('휠렛버거세트', 'setmenu30', 6400, 'setmenu', 'ImageDB\\SetMenu\\setmenu31.jpg', 0),
	('레몬에이드', 'drink1', 2200, 'drink', 'ImageDB\\Drink\\drink1.png', 0),
	('마운틴듀', 'drink2', 1600, 'drink', 'ImageDB\\Drink\\drink2.png', 0),
	('미린다', 'drink3', 1600, 'drink', 'ImageDB\\Drink\\drink3.png', 0),
	('사이다', 'drink4', 1600, 'drink', 'ImageDB\\Drink\\drink4.png', 0),
	('아메리카노(HOT)', 'drink5', 1500, 'drink', 'ImageDB\\Drink\\drink5.png', 0),
	('아메리카노(ICE)', 'drink6', 2000, 'drink', 'ImageDB\\Drink\\drink6.png', 0),
	('오렌지주스', 'drink7', 2000, 'drink', 'ImageDB\\Drink\\drink7.png', 0),
	('청포도에이드', 'drink8', 2200, 'drink', 'ImageDB\\Drink\\drink8.png', 0),
	('콜라', 'drink9', 1600, 'drink', 'ImageDB\\Drink\\drink9.png', 0),
	('갈릭김떡만', 'side1', 3500, 'side', 'ImageDB\\Side\\side1.png', 0),
	('고구마치즈팝콘볼', 'side2', 4000, 'side', 'ImageDB\\Side\\side2.png', 0),
	('공룡치킨', 'side3', 3200, 'side', 'ImageDB\\Side\\side3.png', 0),
	('달콤초코볼', 'side4', 4000, 'side', 'ImageDB\\Side\\side4.png', 0),
	('달콤카라멜볼', 'side5', 4000, 'side', 'ImageDB\\Side\\side5.png', 0),
	('도깨비치즈볼', 'side6', 4000, 'side', 'ImageDB\\Side\\side6.png', 0),
	('랜치소스', 'side7', 1000, 'side', 'ImageDB\\Side\\side7.png', 0),
	('맘스스낵볼세트', 'side8', 4200, 'side', 'ImageDB\\Side\\side8.png', 0),
	('맘스양념소스', 'side9', 1000, 'side', 'ImageDB\\Side\\side9.png', 0),
	('매콤김떡만', 'side10', 3500, 'side', 'ImageDB\\Side\\side10.png', 0),
	('바삭크림치즈볼', 'side11', 4000, 'side', 'ImageDB\\Side\\side11.png', 0),
	('베이컨에그랩', 'side12', 4500, 'side', 'ImageDB\\Side\\side12.png', 0),
	('어니언치즈감자', 'side13', 3200, 'side', 'ImageDB\\Side\\side13.png', 0),
	('에그랩', 'side14', 4000, 'side', 'ImageDB\\Side\\side14.png', 0),
	('치즈감자', 'side15', 2800, 'side', 'ImageDB\\Side\\side15.png', 0),
	('치즈스틱(2조각)', 'side16', 2000, 'side', 'ImageDB\\Side\\side16.png', 0),
	('치킨무', 'side17', 500, 'side', 'ImageDB\\Side\\side17.png', 0),
	('케이준양념감자', 'side18', 3500, 'side', 'ImageDB\\Side\\side18.png', 0),
	('코울슬로', 'side19', 1800, 'side', 'ImageDB\\Side\\side19.png', 0),
	('콘샐러드', 'side20', 1800, 'side', 'ImageDB\\Side\\side20.png', 0),
	('팝콘볼', 'side21', 3500, 'side', 'ImageDB\\Side\\side21.png', 0),
	('할라피뇨너겟', 'side22', 4500, 'side', 'ImageDB\\Side\\side22.png', 0),
	('휠랩', 'side23', 4000, 'side', 'ImageDB\\Side\\side23.png', 0),
	('화이트갈릭싸이버거', 'buger23', 4900, 'buger', 'ImageDB\\Buger\\buger23.png', 0),
	('화이트갈릭싸이버거세트', 'setmenu31', 7200, 'setmenu', 'ImageDB\\SetMenu\\setmenu30.jpg', 0),
	('치즈프라이', 'chesefry', 1000, 'pickside', 'ImageDB\\Side_Add\\chesefry.png', 0),
	('어니언치즈프라이', 'onionchesefry', 1000, 'pickside', 'ImageDB\\Side_Add\\onionchesefry.png', 0),
	('케이준양념감자 소', 'mediumfry', 0, 'pickside', 'ImageDB\\Side_Add\\mediumfry.png', 0),
	('사이다', 'cider', 0, 'pickdrink', 'ImageDB\\Drink_Add\\drink4.png', 0),
	('콜라', 'cola', 0, 'pickdrink', 'ImageDB\\Drink_Add\\drink9.png', 0),
	('오렌지주스', 'orange', 400, 'pickdrink', 'ImageDB\\Drink_Add\\drink7.png', 0),
	('마운틴듀', 'Mountain', 0, 'pickdrink', 'ImageDB\\Drink_Add\\drink2.png', 0),
	('레몬에이드', 'lemon', 600, 'pickdrink', 'ImageDB\\Drink_Add\\drink1.png', 0),
	('청포도에이드', 'grape', 600, 'pickdrink', 'ImageDB\\Drink_Add\\drink8.png', 0),
	('아메리카노(HOT)', 'hot', 0, 'pickdrink', 'ImageDB\\Drink_Add\\drink5.png', 0),
	('아메리카노(ICE)', 'ice', 0, 'pickdrink', 'ImageDB\\Drink_Add\\drink6.png', 0),
	('미린다', 'mirinda', 0, 'pickdrink', 'ImageDB\\Drink_Add\\drink3.png', 0);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
menu