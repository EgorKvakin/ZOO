-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 20 2022 г., 16:00
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `zoo`
--

-- --------------------------------------------------------

--
-- Структура таблицы `accounting`
--

CREATE TABLE `accounting` (
  `id` int(11) NOT NULL,
  `income` decimal(10,0) NOT NULL,
  `expenses` decimal(10,0) NOT NULL,
  `profit` decimal(10,0) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `accounting`
--

INSERT INTO `accounting` (`id`, `income`, `expenses`, `profit`, `date`) VALUES
(71, '15000', '11250', '3750', '2022-05-31 23:47:27'),
(72, '30150', '181500', '-151350', '2022-06-20 14:21:37');

-- --------------------------------------------------------

--
-- Структура таблицы `customers`
--

CREATE TABLE `customers` (
  `id` int(11) NOT NULL,
  `Name` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Surname` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `PhoneNumber` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `customers`
--

INSERT INTO `customers` (`id`, `Name`, `Surname`, `PhoneNumber`) VALUES
(0, 'Anonim', 'Anonim', 'Anonim');

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `Name` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kolvo` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`id`, `Name`, `kolvo`, `Price`) VALUES
(21, 'Сухой корм', 1100, '50.00'),
(23, 'Хомяки', 1000, '100.00'),
(25, 'Питоны', 2000, '4000.00'),
(27, 'Рыбки', 950, '200.00'),
(28, 'Ошейники от блох', 99, '150.00');

-- --------------------------------------------------------

--
-- Структура таблицы `provider`
--

CREATE TABLE `provider` (
  `id` int(11) NOT NULL,
  `firm_name` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `surname` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `firm_addres` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telephone_number` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `provider`
--

INSERT INTO `provider` (`id`, `firm_name`, `name`, `surname`, `firm_addres`, `telephone_number`) VALUES
(1, 'ООО \"Веселый Молочник\"', 'Василий', 'Иванович', 'г.Екатеринбург', '+79526853231');

-- --------------------------------------------------------

--
-- Структура таблицы `sale`
--

CREATE TABLE `sale` (
  `id` int(11) NOT NULL,
  `customersid` int(11) NOT NULL,
  `stuffid` int(11) NOT NULL,
  `productsid` int(11) NOT NULL,
  `kolvo` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `sale`
--

INSERT INTO `sale` (`id`, `customersid`, `stuffid`, `productsid`, `kolvo`, `price`, `date`) VALUES
(25, 0, 9, 23, 100, '10000.00', '2022-05-31 23:21:20'),
(27, 0, 9, 21, 100, '5000.00', '2022-05-31 23:26:07'),
(32, 0, 9, 27, 100, '20000.00', '2022-06-08 13:41:09'),
(33, 0, 9, 27, 50, '10000.00', '2022-06-08 13:45:22'),
(34, 0, 9, 28, 1, '150.00', '2022-06-08 17:46:57');

-- --------------------------------------------------------

--
-- Структура таблицы `stuff`
--

CREATE TABLE `stuff` (
  `id` int(11) NOT NULL,
  `name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `surname` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `position` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `login` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `stuff`
--

INSERT INTO `stuff` (`id`, `name`, `surname`, `position`, `login`, `password`) VALUES
(8, 'Андрей', 'Ершов', 'Администратор', 'Admin', 'Admin'),
(9, 'Валерий', 'Жмышенко', 'Кассир', 'Jmih', '228');

-- --------------------------------------------------------

--
-- Структура таблицы `supply`
--

CREATE TABLE `supply` (
  `id` int(11) NOT NULL,
  `providerid` int(11) NOT NULL,
  `productsid` int(11) NOT NULL,
  `supply_date` datetime NOT NULL,
  `kolvo` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `supply`
--

INSERT INTO `supply` (`id`, `providerid`, `productsid`, `supply_date`, `kolvo`, `price`) VALUES
(38, 1, 21, '2022-05-31 00:00:00', 100, '3750.00'),
(39, 1, 23, '2022-05-31 00:00:00', 100, '7500.00'),
(40, 1, 23, '2022-05-31 00:00:00', 1000, '75000.00'),
(41, 1, 21, '2022-05-31 00:00:00', 1000, '37500.00'),
(42, 1, 25, '2022-05-31 00:00:00', 1000, '3000000.00'),
(45, 1, 21, '2022-06-01 00:00:00', 40, '1500.00'),
(46, 1, 21, '2022-06-01 00:00:00', 100, '3750.00'),
(47, 1, 27, '2022-06-08 00:00:00', 100, '15000.00'),
(48, 1, 27, '2022-06-08 00:00:00', 1000, '150000.00'),
(49, 1, 28, '2022-06-08 00:00:00', 100, '11250.00');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `accounting`
--
ALTER TABLE `accounting`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`id`),
  ADD KEY `stuffid` (`stuffid`),
  ADD KEY `productsid` (`productsid`),
  ADD KEY `customersid` (`customersid`);

--
-- Индексы таблицы `stuff`
--
ALTER TABLE `stuff`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `supply`
--
ALTER TABLE `supply`
  ADD PRIMARY KEY (`id`),
  ADD KEY `productsid` (`productsid`),
  ADD KEY `providerid` (`providerid`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `accounting`
--
ALTER TABLE `accounting`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT для таблицы `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT для таблицы `provider`
--
ALTER TABLE `provider`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `sale`
--
ALTER TABLE `sale`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT для таблицы `stuff`
--
ALTER TABLE `stuff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `supply`
--
ALTER TABLE `supply`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `sale`
--
ALTER TABLE `sale`
  ADD CONSTRAINT `sale_ibfk_1` FOREIGN KEY (`stuffid`) REFERENCES `stuff` (`id`),
  ADD CONSTRAINT `sale_ibfk_2` FOREIGN KEY (`productsid`) REFERENCES `products` (`id`),
  ADD CONSTRAINT `sale_ibfk_3` FOREIGN KEY (`customersid`) REFERENCES `customers` (`id`);

--
-- Ограничения внешнего ключа таблицы `supply`
--
ALTER TABLE `supply`
  ADD CONSTRAINT `supply_ibfk_1` FOREIGN KEY (`productsid`) REFERENCES `products` (`id`),
  ADD CONSTRAINT `supply_ibfk_2` FOREIGN KEY (`providerid`) REFERENCES `provider` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
