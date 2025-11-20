# APITestingTasks
**Задачи 1 и 2 можно решать в консольном приложении.**

**Использовать любое решение для отправки запросов(В идеале RestSharp)**

**Задачу 3 предпочтительно сделать в виде теста с ассертами на любом фрейме**

**(xUnit, NUnit etc)**


**Задача 1**

Реализовать метод отправки GET запроса https://swapi.dev/api/people/1/

В ответ на запрос возвращается информация по герою Звездных войн
```
{
    "name": "Luke Skywalker", 
    "height": "172", 
    "mass": "77", 
    "hair_color": "blond",
    "skin_color": "fair",
    "eye_color": "blue",
    "birth_year": "19BBY",
    "gender": "male", 
    "homeworld": "https://swapi.dev/api/planets/1/", 
    "films": [
        "https://swapi.dev/api/films/1/", 
        "https://swapi.dev/api/films/2/", 
        "https://swapi.dev/api/films/3/", 
        "https://swapi.dev/api/films/6/"
    ], 
    "species": [], 
    "vehicles": [
        "https://swapi.dev/api/vehicles/14/", 
        "https://swapi.dev/api/vehicles/30/"
    ], 
    "starships": [
        "https://swapi.dev/api/starships/12/", 
        "https://swapi.dev/api/starships/22/"
    ], 
    "created": "2014-12-09T13:50:51.644000Z", 
    "edited": "2014-12-20T21:17:56.891000Z", 
    "url": "https://swapi.dev/api/people/1/"
}
```

Десериализовать ответ в объект и вывести в консоль список ссылок на фильмы (ключ ‘films’)

__________________________________________________________________________________________

**Задача 2**

Реализовать метод отправки GET запроса https://reqres.in/api/users?page=2

В ответ на запрос возвращается список пользователей

Десериализовать ответ и вывести в консоль email пользователя по имени **George Edwards**

__________________________________________________________________________________________

**Задача 3**

Реализовать метод отправки POST запроса https://reqres.in/api/users

Запрос создает нового пользователя в системе

Тело запроса должно содержать json следующего вида:

```
{
    "name": "morpheus",
    "job": "leader"
}
```

Отправить запрос и убедиться, что получен статус 201, а так же, что в ответе вернулся id нового пользователя
