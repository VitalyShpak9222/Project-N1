-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 30 2023 г., 20:47
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `taskmanager`
--

-- --------------------------------------------------------

--
-- Структура таблицы `departments`
--

CREATE TABLE `departments` (
  `Id` int(11) NOT NULL,
  `Department` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `departments`
--

INSERT INTO `departments` (`Id`, `Department`) VALUES
(7, ''),
(0, 'Не указан'),
(1, 'Отдел_1'),
(2, 'Отдел_2'),
(3, 'Отдел_3'),
(4, 'Отдел_4'),
(5, 'Отдел_5'),
(6, 'Отдел_6');

-- --------------------------------------------------------

--
-- Структура таблицы `message`
--

CREATE TABLE `message` (
  `Id_1` int(10) UNSIGNED NOT NULL,
  `Id_2` int(10) UNSIGNED NOT NULL,
  `Text_1` varchar(255) NOT NULL,
  `Text_2` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `prioritystatus`
--

CREATE TABLE `prioritystatus` (
  `Id` int(11) NOT NULL,
  `Priority` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `prioritystatus`
--

INSERT INTO `prioritystatus` (`Id`, `Priority`) VALUES
(0, 'Не указан'),
(1, 'Низкий'),
(2, 'Средний'),
(3, 'Высокий');

-- --------------------------------------------------------

--
-- Структура таблицы `problems`
--

CREATE TABLE `problems` (
  `Id` int(11) UNSIGNED NOT NULL,
  `Priority` int(11) NOT NULL,
  `Status` int(11) NOT NULL,
  `Applicant` int(11) UNSIGNED NOT NULL,
  `Description` varchar(255) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `Departments` int(11) NOT NULL,
  `Report` varchar(255) NOT NULL,
  `Responsible` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `problems`
--

INSERT INTO `problems` (`Id`, `Priority`, `Status`, `Applicant`, `Description`, `StartDate`, `EndDate`, `Departments`, `Report`, `Responsible`) VALUES
(16, 3, 2, 2, 'Not able to run', '2023-03-30', '2034-10-12', 5, '', 0),
(17, 2, 2, 2, 'something', '2023-03-30', '2323-02-11', 1, '', 0),
(18, 3, 2, 2, 'drink water', '2023-03-30', '2222-09-23', 3, '', 0),
(19, 1, 2, 2, 'Eat food', '2023-03-30', '2222-11-11', 6, '', 0),
(20, 0, 1, 2, 'read book', '0001-01-01', '3333-02-01', 0, '', 0),
(21, 3, 2, 2, 'lay on bed', '2023-03-30', '2233-07-09', 4, '', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `problemstatus`
--

CREATE TABLE `problemstatus` (
  `Id` int(11) NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `problemstatus`
--

INSERT INTO `problemstatus` (`Id`, `Status`) VALUES
(1, 'Ожидают рассмотрения'),
(2, 'Приняты 1-й линией'),
(3, 'Приняты 2-й линией'),
(4, 'В разработке'),
(5, 'В тестировании'),
(6, 'Решены');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `Id` int(11) UNSIGNED NOT NULL,
  `Login` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Surname` varchar(50) NOT NULL,
  `Status` int(11) UNSIGNED NOT NULL,
  `Department` varchar(255) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Mail` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`Id`, `Login`, `Name`, `Surname`, `Status`, `Department`, `Password`, `Mail`) VALUES
(2, 'test', 'test', 'test', 1, '', '123', 'test'),
(3, 'Engineer', 'Ruslan', 'Engine', 2, '', '123', 'ruslanEngine'),
(4, 'Second', 'Aliya', 'Yakupova', 3, '', '123', 'aliyayakupova');

-- --------------------------------------------------------

--
-- Структура таблицы `usersstatsus`
--

CREATE TABLE `usersstatsus` (
  `Id` int(11) UNSIGNED NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `usersstatsus`
--

INSERT INTO `usersstatsus` (`Id`, `Status`) VALUES
(1, 'Пользователь'),
(2, 'Инженер 1-й линии'),
(3, 'Инженер 2-й линии');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Department` (`Department`);

--
-- Индексы таблицы `message`
--
ALTER TABLE `message`
  ADD PRIMARY KEY (`Id_1`),
  ADD KEY `id_2` (`Id_2`);

--
-- Индексы таблицы `prioritystatus`
--
ALTER TABLE `prioritystatus`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `problems`
--
ALTER TABLE `problems`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Responsible` (`Responsible`),
  ADD KEY `Applicant` (`Applicant`),
  ADD KEY `Departments` (`Departments`),
  ADD KEY `priority_id` (`Priority`),
  ADD KEY `Status` (`Status`);

--
-- Индексы таблицы `problemstatus`
--
ALTER TABLE `problemstatus`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Status` (`Status`),
  ADD KEY `Department` (`Department`);

--
-- Индексы таблицы `usersstatsus`
--
ALTER TABLE `usersstatsus`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`),
  ADD KEY `Id_2` (`Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `departments`
--
ALTER TABLE `departments`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `prioritystatus`
--
ALTER TABLE `prioritystatus`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `problems`
--
ALTER TABLE `problems`
  MODIFY `Id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT для таблицы `problemstatus`
--
ALTER TABLE `problemstatus`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `message`
--
ALTER TABLE `message`
  ADD CONSTRAINT `message_ibfk_1` FOREIGN KEY (`Id_2`) REFERENCES `users` (`Id`);

--
-- Ограничения внешнего ключа таблицы `problems`
--
ALTER TABLE `problems`
  ADD CONSTRAINT `problems_ibfk_1` FOREIGN KEY (`Priority`) REFERENCES `prioritystatus` (`Id`),
  ADD CONSTRAINT `problems_ibfk_2` FOREIGN KEY (`Departments`) REFERENCES `departments` (`Id`),
  ADD CONSTRAINT `problems_ibfk_3` FOREIGN KEY (`Status`) REFERENCES `problemstatus` (`Id`);

--
-- Ограничения внешнего ключа таблицы `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_2` FOREIGN KEY (`Department`) REFERENCES `departments` (`Department`),
  ADD CONSTRAINT `users_ibfk_3` FOREIGN KEY (`Status`) REFERENCES `usersstatsus` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
