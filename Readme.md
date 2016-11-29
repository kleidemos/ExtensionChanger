# Лабораторная работа № 1
# Использование базовых возможностей системы контроля версий Git  

## Источники информации
1.	[Оф.сайт](https://git-scm.com)
2.	[Лучшая книга по Git (ProGit, теперь на русском)](https://git-scm.com/book/ru/v1)
3.	[Вики](https://ru.wikipedia.org/wiki/Git)
4.	[Пошаговая инструкция по использованию Git](https://githowto.com/ru/)

## Задачи
1.	Ознакомиться с теоретическим материалом из приведённых источников.
2.	Скачать Git с [официального сайта](https://git-scm.com/downloads) и установить его.
3.	Выполнить первичную настройку (имя, емаил, окончания строк).
4.	Создайте папку и поместите в неё файлы любого своего программного проекта (структура может содержать вложенные папки).
5.	Откройте консоль, перейдите в каталог с вашим проектом
6.	Создайте репозитарий и добавьте в него все файлы вашего проекта
7.	Просмотрите статус репозитария, выполните commit, повторно проверьте статус
8.	Измените содержимое нескольких файлов, создайте новые файлы. Просмотрите статус репозитария, проиндексируйте раздельно несколько изменений, выполните серию коммитов. Выполните коммит с ключом –m и без него.
9.	Создайте файл .gitignore, добавьте в него имена и маски имён файлов, которые не должны добавляться в репозитарий. Проверьте корректность работы этого механизма с вашими настройками, зафиксируйте результат в виде снимков экрана.
10.	Выведите историю репозитария в полной и сокращённой (однострочной) форме. Освойте дополнительные параметры и режимы отображения команды log.
11.	Настройте [псевдонимы команд](https://githowto.com/ru/aliases) 
12.	Выполните получение версии файла из репозитария (откат, checkout). Просмотрите содержимое файлов с последними изменениями.
13.	Вернитесь к последней версии в ветке master. Просмотрите содержимое файлов, которые были затронуты данной операцией.
14.	Выполните сравнение (просмотр различий) текущего состояния какого-либо файла с зафиксированной версией из коммита.
15.	Выполните клонирование любого репозитария с Github
16.	Создайте собственную учётную запись на Github, выполните загрузку своего репозитария на сервер. 
17.	Выполните изменение файлов локального репозитария, загрузите изменения на сервер.
18.	Выполните изменение файлов локального репозитария, откатите изменения, загрузив версию с сервера.
19.	Освойте работу с репозитарием git с помощью любой среды разработки (IDE. Например, NetBeans, Eclipse, среды от JetBrains) – повторите шаги, выполненные ранее в командной строке.
20.	Сохраните все выполненные команды в текстовом виде или в виде снимков экрана (screenshots). Продемонстрируйте проделанную работу. Защитите работу, ответив на контрольные вопросы. 

## Ход выполнения работ
1.	Ознакомиться с теоретическим материалом из приведённых источников.

2.	Скачать Git с [официального сайта](https://git-scm.com/downloads) и установить его.

    Git клиент был установлен вместе с Visual Studio Community в допотопную эпоху.

3.	Выполнить первичную настройку (имя, емаил, окончания строк).

    Также была произведена давным давно. Осушествляется посредством комманд:

    Настройки имени и почты: 

        $ git config --global user.name "Зайнуллин Фархад Ильнурович" 
        $ git config --global user.mail "zaynullin.farkhad.pro@yandex.ru" 
        // на самом деле я использую другой адрес
        
    Настройка окончания строк

        $ git config --global core.autocrlf true

4.	Создайте папку и поместите в неё файлы любого своего программного проекта (структура может содержать вложенные папки).

    В качестве подопытного будет использоваться только что созданный проект ExtensionChanger.   
    Задача данного проекта проста, нужно изменить разрешения всех файлов в папке на указанное пользователем. _// Данную операцию легко можно проделать посредством одной команды в cmd, но как показал мой предыдущий опыт, даже в рамках данной лаборатории мне довольно таки сложно писать проект абсолютно оторванный от реального мира._   
    Проект пишется на F#, в комплекте с проектом будет идти "документация" в markdown-е (сей файл). Т.к. я не делал черновой прогон, то я не могу гарантировать, что данный файл сохранит свою структуру по мере развития сюжета. Также я не могу гарантировать, что процесс будет развиваться линейно. Поэтому прошу понять и простить возможные вставки, deus ex machina, неверные архитектурные решения (если до такого дойдет), а также огромное количество орфографических и синтаксических ошибок.  
    _// Честно говоря, я даже не знаю, как конкретно будет реализовываться выше обозначенная задача._

5.	Откройте консоль, перейдите в каталог с вашим проектом

        $ cd "C:\Users\MainKleiPC\Documents\visual studio 2015\Projects\ExtensionChanger"

6.	Создайте репозитарий и добавьте в него все файлы вашего проекта

        $ git init
        Initialized empty Git repository in C:/Users/MainKleiPC/Documents/visual studio 2015/Projects/ExtensionChanger/.git/
        $ git add *

7.	Просмотрите статус репозитария, выполните commit, повторно проверьте статус

    Проверка статуса: 

        $ git status
        On branch master

        Initial commit

        Changes to be committed:
        (use "git rm --cached <file>..." to unstage)

                new file:   ExtensionChanger.sln
                new file:   ExtensionChanger/App.config
                new file:   ExtensionChanger/AssemblyInfo.fs
                new file:   ExtensionChanger/ExtensionChanger.fsproj
                new file:   ExtensionChanger/Program.fs
                new file:   Readme.md

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/
    .vs/ не добавлен т.к. по умолчанию git игнорирует файлы начинающиеся на '.'.

    Коммит:

        $ git commit -m "Инициация."
        [master (root-commit) 4c3d5a7] Инициация.
        6 files changed, 230 insertions(+)
        create mode 100644 ExtensionChanger.sln
        create mode 100644 ExtensionChanger/App.config
        create mode 100644 ExtensionChanger/AssemblyInfo.fs
        create mode 100644 ExtensionChanger/ExtensionChanger.fsproj
        create mode 100644 ExtensionChanger/Program.fs
        create mode 100644 Readme.md

    Проверка статуса:

        $ git status
        On branch master
        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/

        nothing added to commit but untracked files present (use "git add" to track)

    Как видим, проект не содержит измененных файлов, за исключением .vs/. Данные строки пишутся после всех операций (иначе данный файл уже был бы в изменных).

8.	Измените содержимое нескольких файлов, создайте новые файлы. Просмотрите статус репозитария, проиндексируйте раздельно несколько изменений, выполните серию коммитов. Выполните коммит с ключом –m и без него.

    Внес информацию о 7 пункте;  
    Добавил файл Changer.fs;  
    Сделал черновую реализацию. 

        $ git status
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   ExtensionChanger/ExtensionChanger.fsproj
                modified:   ExtensionChanger/Program.fs
                modified:   Readme.md

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/
                ExtensionChanger/Changer.fs
                ExtensionChanger/bin/
                ExtensionChanger/obj/

        no changes added to commit (use "git add" and/or "git commit -a")

    Зарегистировал файл в коммите:

        $ git add "ExtensionChanger/Changer.fs"

    Статус:

        $ git status
        On branch master
        Changes to be committed:
        (use "git reset HEAD <file>..." to unstage)

                new file:   ExtensionChanger/Changer.fs

        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   ExtensionChanger/ExtensionChanger.fsproj
                modified:   ExtensionChanger/Program.fs
                modified:   Readme.md

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/
                ExtensionChanger/bin/
                ExtensionChanger/obj/

    Закоммитил:

        $ git commit -m "Добавил модуль выполняющий основную работу."
        [master 631deb0] Добавил модуль выполняющий основную работу.
        1 file changed, 7 insertions(+)
        create mode 100644 ExtensionChanger/Changer.fs

    Статус:

        $ git status
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   ExtensionChanger/ExtensionChanger.fsproj
                modified:   ExtensionChanger/Program.fs
                modified:   Readme.md

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/
                ExtensionChanger/bin/
                ExtensionChanger/obj/

        no changes added to commit (use "git add" and/or "git commit -a")

    Добавил файл проекта:

        $ git add ExtensionChanger/ExtensionChanger.fsproj
    
    Закоммитил:

        $ git commit -m "Изменения в файле проект, по идее данный коммит должен был идти в рамках предыдущего."
        [master 7380bbc] Изменения в файле проект, по идее данный коммит должен был идти в рамках предыдущего.
        1 file changed, 1 insertion(+)

    Статус:

        $ git status
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   ExtensionChanger/Program.fs
                modified:   Readme.md

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/
                ExtensionChanger/bin/
                ExtensionChanger/obj/

        no changes added to commit (use "git add" and/or "git commit -a")

