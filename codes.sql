-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 01, 2025 at 03:57 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `codes`
--

-- --------------------------------------------------------

--
-- Table structure for table `begbug`
--

CREATE TABLE `begbug` (
  `id` int(11) NOT NULL,
  `code` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `begbug`
--

INSERT INTO `begbug` (`id`, `code`) VALUES
(1, 'int main() {\nint x = 5\nConsole.WriteLine(x);\nreturn 0;\n}'),
(2, 'int main() {\nint number = 10;\nConsole.WriteLine(num);\nreturn 0;\n}'),
(3, 'int main() {\nint i = 0;\nwhile (i < 5) {\n  Console.WriteLine(i);\n}\nreturn 0;\n}'),
(4, 'int main() {\nstring name = \"Alice\";\nConsole.WriteLine(\"Hello \" + name)\nreturn 0;\n}'),
(5, 'int main() {\nfor (int i = 0; i < 3; i++)\n  Console.WriteLine(i);\n}'),
(6, 'int main() {\nint age = 18;\nif (age = 18) {\n  Console.WriteLine(\"Adult\");\n}\nreturn 0;\n}'),
(7, 'int main() {\nint[] nums = {1, 2, 3};\nConsole.WriteLine(nums[3]);\nreturn 0;\n}'),
(8, 'int main() {\nConsole.WriteLine(\"Hello\");\nreturn 0;\n'),
(9, 'int main() {\nint a = 10, b = 0;\nConsole.WriteLine(a / b);\nreturn 0;\n}'),
(10, 'int main() {\nstring s = null;\nConsole.WriteLine(s.Length);\nreturn 0;\n}'),
(11, 'int main() {\nList<int> numbers = null;\nConsole.WriteLine(numbers[0]);\nreturn 0;\n}'),
(12, 'int main() {\nint[] arr = new int[3];\narr[3] = 5;\nreturn 0;\n}'),
(13, 'int main() {\nstring name = \"Bob\";\nConsole.WriteLine(\"Name: \" + names);\nreturn 0;\n}'),
(14, 'int main() {\nbool isTrue = \"true\";\nif (isTrue) Console.WriteLine(\"Yes\");\nreturn 0;\n}'),
(15, 'int main() {\nfor (int i = 0; i < 5; ) {\n  Console.WriteLine(i);\n}\nreturn 0;\n}'),
(16, 'int main() {\nint i = 0;\ndo {\n  Console.WriteLine(i);\n} while i < 3;\nreturn 0;\n}'),
(17, 'int main() {\nint num = Convert.ToInt32(\"abc\");\nConsole.WriteLine(num);\nreturn 0;\n}'),
(18, 'int main() {\nConsole.WriteLine(Math.Sqrt(-1));\nreturn 0;\n}'),
(19, 'int main() {\nDateTime dt = \"2024-01-01\";\nConsole.WriteLine(dt);\nreturn 0;\n}'),
(20, 'int main() {\nint[] values = null;\nforeach (int v in values) {\n  Console.WriteLine(v);\n}\nreturn 0;\n}');

-- --------------------------------------------------------

--
-- Table structure for table `begsol`
--

CREATE TABLE `begsol` (
  `id` int(11) NOT NULL,
  `code` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `begsol`
--

INSERT INTO `begsol` (`id`, `code`) VALUES
(1, 'int main() {\nint x = 5;\nConsole.WriteLine(x);\nreturn 0;\n}'),
(2, 'int main() {\nint number = 10;\nConsole.WriteLine(number);\nreturn 0;\n}'),
(3, 'int main() {\nint i = 0;\nwhile (i < 5) {\n  Console.WriteLine(i);\n  i++;\n}\nreturn 0;\n}'),
(4, 'int main() {\nstring name = \"Alice\";\nConsole.WriteLine(\"Hello \" + name);\nreturn 0;\n}'),
(5, 'int main() {\nfor (int i = 0; i < 3; i++) {\n  Console.WriteLine(i);\n}\nreturn 0;\n}'),
(6, 'int main() {\nint age = 18;\nif (age == 18) {\n  Console.WriteLine(\"Adult\");\n}\nreturn 0;\n}'),
(7, 'int main() {\nint[] nums = {1, 2, 3};\nConsole.WriteLine(nums[2]);\nreturn 0;\n}'),
(8, 'int main() {\nConsole.WriteLine(\"Hello\");\nreturn 0;\n}'),
(9, 'int main() {\nint a = 10, b = 2;\nConsole.WriteLine(a / b);\nreturn 0;\n}'),
(10, 'int main() {\nstring s = \"\";\nConsole.WriteLine(s.Length);\nreturn 0;\n}'),
(11, 'int main() {\nList<int> numbers = new List<int> {1, 2, 3};\nConsole.WriteLine(numbers[0]);\nreturn 0;\n}'),
(12, 'int main() {\nint[] arr = new int[3];\narr[2] = 5;\nreturn 0;\n}'),
(13, 'int main() {\nstring name = \"Bob\";\nConsole.WriteLine(\"Name: \" + name);\nreturn 0;\n}'),
(14, 'int main() {\nbool isTrue = true;\nif (isTrue) Console.WriteLine(\"Yes\");\nreturn 0;\n}'),
(15, 'int main() {\nfor (int i = 0; i < 5; i++) {\n  Console.WriteLine(i);\n}\nreturn 0;\n}'),
(16, 'int main() {\nint i = 0;\ndo {\n  Console.WriteLine(i);\n  i++;\n} while (i < 3);\nreturn 0;\n}'),
(17, 'int main() {\nint num;\nif (int.TryParse(\"abc\", out num)) {\n  Console.WriteLine(num);\n} else {\n  Console.WriteLine(\"Invalid input\");\n}\nreturn 0;\n}'),
(18, 'int main() {\nConsole.WriteLine(double.NaN);\nreturn 0;\n}'),
(19, 'int main() {\nDateTime dt = DateTime.Parse(\"2024-01-01\");\nConsole.WriteLine(dt);\nreturn 0;\n}'),
(20, 'int main() {\nint[] values = {1, 2, 3};\nforeach (int v in values) {\n  Console.WriteLine(v);\n}\nreturn 0;\n}');

-- --------------------------------------------------------

--
-- Table structure for table `fillintheblanks`
--

CREATE TABLE `fillintheblanks` (
  `id` int(11) NOT NULL,
  `code_with_blank` text NOT NULL,
  `correct_word` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fillintheblanks`
--

INSERT INTO `fillintheblanks` (`id`, `code_with_blank`, `correct_word`) VALUES
(1, 'Console.____(\"Hello!\");', 'WriteLine'),
(2, 'int number = ____;', '10'),
(3, 'if (a > b) { Console.WriteLine(\"A is greater\"); } ____ { Console.WriteLine(\"B is greater\"); }', 'else'),
(4, 'string name = Console.____();', 'ReadLine'),
(5, 'int i = 0;\nwhile (i < 5) {\n  Console.WriteLine(i);\n  i____;\n}', '++'),
(6, 'int[] arr = new ____[5];', 'int'),
(7, '____ (true) {\n  Console.WriteLine(\"Looping\");\n}', 'while'),
(8, 'for (int i = 0; i < 3; ____) {\n  Console.WriteLine(i);\n}', 'i++'),
(9, 'bool isCorrect = ____;', 'true'),
(10, 'try {\n  int x = 10 / 0;\n} ____ (Exception ex) {\n  Console.WriteLine(\"Error\");\n}', 'catch'),
(11, '____ (Exception ex) {\n  Console.WriteLine(ex.Message);\n}', 'catch'),
(12, 'int x = Math.____(9);', 'Sqrt'),
(13, 'string name = \"John\";\nConsole.WriteLine(name.____());', 'ToUpper'),
(14, 'int[] nums = {1, 2, 3};\nConsole.WriteLine(nums.____);', 'Length'),
(15, 'DateTime now = DateTime.____;', 'Now'),
(16, 'string s = \"hello\";\nConsole.WriteLine(s.____(1, 3));', 'Substring'),
(17, 'List<int> list = new List<int>();\nlist.____(5);', 'Add'),
(18, 'Dictionary<int, string> dict = new Dictionary<int, string>();\ndict.____(1);', 'Remove'),
(19, 'Console.WriteLine(\"Sum: \" + (5 ____ 3));', '+'),
(20, 'for (int i = 10; i >= 0; ____)', 'i--');

-- --------------------------------------------------------

--
-- Table structure for table `high_scores`
--

CREATE TABLE `high_scores` (
  `id` int(11) NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  `score` int(11) DEFAULT NULL,
  `date_attempted` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `high_scores`
--

INSERT INTO `high_scores` (`id`, `username`, `score`, `date_attempted`) VALUES
(1, 'Aayan 1', 100, '2025-06-20 16:36:55'),
(2, 'Aayan 2', 50, '2025-06-20 17:03:15');

-- --------------------------------------------------------

--
-- Table structure for table `mcqquestions`
--

CREATE TABLE `mcqquestions` (
  `id` int(11) NOT NULL,
  `question` text DEFAULT NULL,
  `optionA` text DEFAULT NULL,
  `optionB` text DEFAULT NULL,
  `optionC` text DEFAULT NULL,
  `optionD` text DEFAULT NULL,
  `correct_option` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `mcqquestions`
--

INSERT INTO `mcqquestions` (`id`, `question`, `optionA`, `optionB`, `optionC`, `optionD`, `correct_option`) VALUES
(1, 'What is the default value of int in C#?', '0', 'null', '-1', 'undefined', 'A'),
(2, 'Which keyword is used to inherit a class?', 'this', 'base', 'inherit', ':', 'D'),
(3, 'Which access modifier makes members visible everywhere?', 'internal', 'public', 'protected', 'private', 'B'),
(4, 'What does \'static\' mean in C#?', 'Instance only', 'Shared across instances', 'Local variable', 'Not accessible', 'B'),
(5, 'Which collection allows key-value pairs?', 'Array', 'List', 'Dictionary', 'Queue', 'C'),
(6, 'What is the output of Console.WriteLine(3 + \"3\")?', '6', '33', 'Error', '3', 'B'),
(7, 'Which method reads user input from console?', 'Write', 'WriteLine', 'ReadLine', 'Input', 'C'),
(8, 'What is boxing in C#?', 'Converting value type to object', 'Object to value type', 'String to int', 'Int to bool', 'A'),
(9, 'Can a class inherit multiple classes in C#?', 'Yes', 'No', 'Only structs', 'Only interfaces', 'B'),
(10, 'What is the correct way to declare a constant in C#?', 'final int x = 5;', 'const int x = 5;', 'constant x = 5;', 'var const x = 5;', 'B');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `begbug`
--
ALTER TABLE `begbug`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `begsol`
--
ALTER TABLE `begsol`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `fillintheblanks`
--
ALTER TABLE `fillintheblanks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `high_scores`
--
ALTER TABLE `high_scores`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mcqquestions`
--
ALTER TABLE `mcqquestions`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `begbug`
--
ALTER TABLE `begbug`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `begsol`
--
ALTER TABLE `begsol`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `fillintheblanks`
--
ALTER TABLE `fillintheblanks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `high_scores`
--
ALTER TABLE `high_scores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `mcqquestions`
--
ALTER TABLE `mcqquestions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
