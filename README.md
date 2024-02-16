# Моделирование работы двух- и однопросмотрового ассемблера
_Данные программы были написаны в ходе изучения дисциплины 'Системное программирование'_

**Исходные данные:**
* набор основных типовых команд абстрактного процессора, собранных в Таблицу Кодов Операций
* основные псевдокоманды-директивы (задание констант, описание внешних имен и ссылок)
* небольшой исходный текст на языке ассемблера
* адрес загрузки с возможностью изменения

**Результаты работы:**
* промежуточные результаты после первого прохода: Таблица Символических Имен (ТСИ), вспомогательная таблица с частично сгенерированными командами
* окончательные результаты: основные разделы объектного модуля (заголовок, тело, таблица настройки, списки внешних имен и ссылок), сообщения об ошибках


### Реализация двухпросмотрового ассемблера для программы в абсолютном формате
![1](https://github.com/tache-osseuse/assembler_handler/assets/71820145/633e35ab-9105-4c96-b0cd-a97c728754ef)
### Реализация двухпросмотрового ассемблера для программы в перемещаемом формате
![2](https://github.com/tache-osseuse/assembler_handler/assets/71820145/d8fb947d-e072-42f5-9da6-30fa76d63b2f)
### Реализация двухпросмотрового ассемблера для программы в полноперемещаемом формате
![3](https://github.com/tache-osseuse/assembler_handler/assets/71820145/4c586f0a-a062-4714-b2dd-ca3eaa9bcf21)
### Реализация однопросмотрового ассемблера для программы в абсолютном формате
![4](https://github.com/tache-osseuse/assembler_handler/assets/71820145/4eb0d716-0e57-4622-9999-d43ee1232ad6)
### Реализация однопросмотрового ассемблера для программы в перемещаемом формате
![5](https://github.com/tache-osseuse/assembler_handler/assets/71820145/38ce43d9-1624-4616-8b91-f4154a265bc2)
