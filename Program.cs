// int dayNumber = 3;

// switch (dayNumber) {
//     case 5 or 7: Console.WriteLine("Выходной"); 
//     break;
//     default: Console.WriteLine("Будний"); 
//     break;
// }

// int score = 78;

// switch (score) {
//     case >= 0 and < 39:
//         Console.WriteLine("Неудовлетворительно"); 
//         break;
//     case >= 40 and < 59:
//         Console.WriteLine("Удовлетворительно"); 
//         break;
//     case >= 60 and < 79:
//         Console.WriteLine("Хорошо"); 
//         break;
//     case >= 80 and < 100:
//         Console.WriteLine("Отлично"); 
//         break;
// }

// int temp = 20;

// string result = temp switch {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => "Очень жарко"
// };

// string role = "teacher";

// string result = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     not "admin" => "Ограниченный доступ"
// };

// Console.WriteLine(result);

// int age = 20;
// bool hasTicket = true;

// switch (age)
// {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }

// int level = 2;

// switch (level) {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }

// Задача А
// int month = int.Parse(Console.ReadLine());

// string season = month switch
// {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5  => "Весна",
//     6 or 7 or 8  => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine(season);

// //Задача Б
// int age = 17;

// string cat = age switch
// {
//     < 0              => "Ошибка",
//     >= 0 and <= 6    => "Ребёнок",
//     >= 7 and <= 17   => "Подросток",
//     >= 18 and <= 64  => "Взрослый",
//     >= 65            => "Пенсионер"
// };

// Console.WriteLine(cat);

//Вариант 3
// Console.Write("Введите день недели(с маленькой буквы): ");
// string day = Console.ReadLine();

// string schedule = day switch
// {
//     "понедельник" or "вторник" or "среда" or "четверг" or "пятница"
//         => "9:00–21:00",

//     "суббота"
//         => "10:00–20:00",

//     "воскресенье"
//         => "10:00–18:00",

//     _ => "День не распознан"
// };

// Console.WriteLine(schedule);

//Вариант 6
Console.Write("Введите роль (admin/teacher/user): ");
string role = Console.ReadLine();
bool verif = false;
string res = role switch
{
    "admin" => "Полный доступ",
    "teacher" when !verif => "Требуется подтверждение",
    "teacher" => "Доступ преподавателя",
    "user" => "Ограниченный доступ",
    _ => "Доступ запрещён"
};

Console.WriteLine(res);