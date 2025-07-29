# GeniyIdiot

## 📜Описание 
🧠 Шуточный тест «Гений-Идиот», созданный для тестирования пользователей, написан в процессе изучания принципов ООП, файловой системы хранения данных и технологии **Windows Forms**
### Суть приложения
Пользователь отвечает на определённое количество вопросов. Время для ответа ограничено и составляет всего 10 секунд!

* Цель: ответить правильно на максимальное количество вопросов

* В конце тестирования пользователю присваивается _"диагноз"_

Пользователь может воспользоваться **Меню**, в котором он может: выйти из игры, перезапустить игру, посмотреть все результаты тестирования, а также добавить новый вопрос

### Пример работы приложения
#### 🖥️ GeniyIdiotWindowsFormsApp

![ezgif com-video-to-gif-converter (1)](https://github.com/user-attachments/assets/37d78572-13b4-4480-8319-5fcd24c642f7)

#### 📂 GeniyIdiotConsoleApp

![ezgif com-video-to-gif-converter (2)](https://github.com/user-attachments/assets/574f9d7e-380f-40d4-bde1-ee82c569ef46)

## ⚙️Техническая часть
Проект выполнен с соблюдением принципов ООП. Хранение вопросов и результатов осуществляется в отдельных файлах файловой системы с сериализацией/десериализацией в **JSON** с использованием библиотеки Newtonsoft.Json.
* Проект создан на платформе Windows Forms и на консоли
* Создана общая библиотека классов

### 🏗️ Архитектура
Структура каталога решения:

 <img width="357" height="291" alt="image" src="https://github.com/user-attachments/assets/b2a1726a-5abc-4e06-802b-fff04c0683ac" /> <img width="353" height="167" alt="image" src="https://github.com/user-attachments/assets/29f936fb-8e74-4826-96d3-af254773ac88" /> <img width="358" height="302" alt="image" src="https://github.com/user-attachments/assets/3c22ccfb-5945-475b-adb1-de729e00cdff" />

### Работа с JSON
#### 📥Сериализация
<pre><code>
static void Save(List<User> usersResult)
{
    var jsonData=JsonConvert.SerializeObject(usersResult,Formatting.Indented);
    FileProvider.Replace(Path, jsonData);
}
</code></pre>

#### 📤Десериализация
<pre><code>
public static List<User> GetUsersResults()
{
    if(!FileProvider.CheckFile(Path))
    {
        return new List<User>();
    }
    var value = FileProvider.GetValue(Path);
    var userResults=JsonConvert.DeserializeObject<List<User>>(value);
    return userResults;
}
</code></pre>     

