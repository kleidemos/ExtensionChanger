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

        $ git config --global user.name "kleidemos" 
        $ git config --global user.mail "arche-kunktator@yandex.ru" 
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

    Добавил данный файл в коммит:

        $ git add Readme.md

    Статус после добавления, но до написания данных строк:

        $ git status
        On branch master
        Changes to be committed:
        (use "git reset HEAD <file>..." to unstage)

                modified:   Readme.md

        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   ExtensionChanger/Program.fs

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .vs/
                ExtensionChanger/bin/
                ExtensionChanger/obj/

    Статус после этих строк:

        $ git status
        On branch master
        Changes to be committed:
        (use "git reset HEAD <file>..." to unstage)

                modified:   Readme.md

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

    Как видим, Readme.md встречается 2 раза. Это связанно с тем, что в коммите регистрируется не сам файл, а diff.
    Если закоммитить данные сейчас, то текущие изменения не будут зарегестированы коммитом.

        $ git commit -m "Коммит регистрирующий изменения файла, но не регистрирующий ищменения вносимые после. // я без понятия как это объяснить"
        [master e388a5a] Коммит регистрирующий изменения файла, но не регистрирующий ищменения вносимые после. // я без понятия как это объяснить
        1 file changed, 160 insertions(+), 1 deletion(-)
    
    _// Должен сказать, что обычно мои комментарии к коммитам имееют относительно стабильную структуру, но в рамках данной лабораторной, ввиду разрушения четвертой стены мне не удается придерживаться своего стиля._

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

    Как видим, Readme.md считается измененным.

    Коммит без -m:

        $ git add ExtensionChanger/Program.fs
        $ git commit
        // здесь был "редактор"
        [master 4013998] Коммит без -m.
        1 file changed, 5 insertions(+), 2 deletions(-)

    По сути то же самое, но с юзерфрендли комбинацией `Esc -> ":wq" -> Enter`.

    Ну и напоследок:

        $ git add Readme.md
        $ git commit -m "Почти завершенный 8 пункт"
        [master 7693738] Почти завершенный 8 пункт
        1 file changed, 89 insertions(+)
    
    Дабы не впадать в рекурсивный ад, последний коммит не был приведен.


9.	Создайте файл .gitignore, добавьте в него имена и маски имён файлов, которые не должны добавляться в репозитарий. Проверьте корректность работы этого механизма с вашими настройками, зафиксируйте результат в виде снимков экрана.

    Добавил файл .gitignore. Содержимое файла:
        
        .vs/
        ExtensionChanger/bin/
        ExtensionChanger/obj/

    Статус: 

        $ git status
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   Readme.md

        Untracked files:
        (use "git add <file>..." to include in what will be committed)

                .gitignore

        no changes added to commit (use "git add" and/or "git commit -a")

    Коммит:

        $ git add .gitignore
        $ git commit -m "Добавил gitignore."
        [master 4add147] Добавил gitignore.
        1 file changed, 3 insertions(+)
        create mode 100644 .gitignore
        $ git status
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   Readme.md

        no changes added to commit (use "git add" and/or "git commit -a")

10.	Выведите историю репозитария в полной и сокращённой (однострочной) форме. Освойте дополнительные параметры и режимы отображения команды log.

    Стандартный вывод:

        $ git log
        commit 291fdea42b3e32875ce46f3c196bf7f701efa366
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 02:36:26 2016 +0500

            Пункт 9.

        commit 4add1477ca50c0b9b48d041239210e3f6b770bb5
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 02:34:26 2016 +0500

            Добавил gitignore.

        commit c12d75affa006aa5df931249d09caae7c22249f8
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 02:27:25 2016 +0500

            Пункт 8

        commit 769373815f33d73d19e44c0ba6b034312e1e7696
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 02:25:33 2016 +0500

            Почти завершенный 8 пункт

        commit 4013998de4cbd01e70c16794fcb3c2833a9e0062
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 02:18:00 2016 +0500

            Коммит без -m.

        commit e388a5a3463662660dbc0c9b972a5e7005c404a9
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 02:15:23 2016 +0500

            Коммит регистрирующий изменения файла, но не регистрирующий ищменения вносимые после. // я без понятия как это объяснить

        commit 7380bbc2f6b4ebd49afe7a557af0eb0459ef568a
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 01:59:18 2016 +0500

            Изменения в файле проект, по идее данный коммит должен был идти в рамках предыдущего.

        commit 631deb005396d47e0c1adfd0679dcffa36297e57
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 01:57:32 2016 +0500

            Добавил модуль выполняющий основную работу.

        commit 4c3d5a72c59a6573509c85b5761f026219c11cf5
        Author: kleidemos <arche-kunktator@yandex.ru>
        Date:   Wed Nov 30 01:21:35 2016 +0500

            Инициация.

    Короткий:

        $ git log --pretty=oneline
        291fdea42b3e32875ce46f3c196bf7f701efa366 Пункт 9.
        4add1477ca50c0b9b48d041239210e3f6b770bb5 Добавил gitignore.
        c12d75affa006aa5df931249d09caae7c22249f8 Пункт 8
        769373815f33d73d19e44c0ba6b034312e1e7696 Почти завершенный 8 пункт
        4013998de4cbd01e70c16794fcb3c2833a9e0062 Коммит без -m.
        e388a5a3463662660dbc0c9b972a5e7005c404a9 Коммит регистрирующий изменения файла, но не регистрирующий ищменения вносимые после. // я без понятия как это объяснить
        7380bbc2f6b4ebd49afe7a557af0eb0459ef568a Изменения в файле проект, по идее данный коммит должен был идти в рамках предыдущего.
        631deb005396d47e0c1adfd0679dcffa36297e57 Добавил модуль выполняющий основную работу.
        4c3d5a72c59a6573509c85b5761f026219c11cf5 Инициация.

    Есть множество вариантов вывода включая заданные самостоятельно. Также доступна фильтрация по файлам, времени, отношению к коммитам, автору и т.д. Подробнее [здесь](https://git-scm.com/book/ru/v1/Основы-Git-Просмотр-истории-коммитов).

    Вывод "{хеш} {сообщение}" в виде графа последние 4 коммитов.

        $ git log --pretty=format:"%h %s" --graph -4
        * 291fdea Пункт 9.
        * 4add147 Добавил gitignore.
        * c12d75a Пункт 8
        * 7693738 Почти завершенный 8 пункт

11.	Настройте [псевдонимы команд](https://githowto.com/ru/aliases) 

        $ git config --global alias.st status
        $ git st
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   Readme.md

        no changes added to commit (use "git add" and/or "git commit -a")

12.	Выполните получение версии файла из репозитария (откат, checkout). Просмотрите содержимое файлов с последними изменениями.

    Я внес некоторые изменения в файл ExtensionChanger/Changer.fs. После чего:

        $ git st
        On branch master
        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

                modified:   ExtensionChanger/Changer.fs

        no changes added to commit (use "git add" and/or "git commit -a")

    Содержимое:

        $ cat ExtensionChanger/Changer.fs
        module Changer

        open System.IO

        let setExtension ext (directory:DirectoryInfo) =
            directory.GetFiles()
            // я "случайно" снес часть кода

    Откат:
    
        $ git checkout ExtensionChanger/Changer.fs

    Содержимое:

        $ cat ExtensionChanger/Changer.fs
        module Changer

        open System.IO

        let setExtension ext (directory:DirectoryInfo) =
            directory.GetFiles()
            |> Seq.iter (fun p -> File.Move(p.FullName, Path.ChangeExtension(p.FullName, ext)))

    Не понял, какие конкретно изменения я должен был показать, поэтому вывел diff:

        $ git diff
        diff --git a/Readme.md b/Readme.md
        index 45c3773..612c2c0 100644
        --- a/Readme.md
        +++ b/Readme.md
        @@ -465,3 +465,44 @@
                        modified:   Readme.md

                no changes added to commit (use "git add" and/or "git commit -a")
        +
        +12.    Выполните получение версии файла из репозитария (откат, checkout). Просмотрите содержимое файлов с последними изменениями.
        +
        +    Я внес некоторые изменения в файл ExtensionChanger/Changer.fs. После чего:
        +
        +        $ git st
        +        On branch master
        +        Changes not staged for commit:
        +        (use "git add <file>..." to update what will be committed)
        +        (use "git checkout -- <file>..." to discard changes in working directory)
        +
        +                modified:   ExtensionChanger/Changer.fs
        +
        +        no changes added to commit (use "git add" and/or "git commit -a")
        +
        +    Содержимое:
        +
        +        $ cat ExtensionChanger/Changer.fs
        +        module Changer

    _// Здесь лишь начало._

13.	Вернитесь к последней версии в ветке master. Просмотрите содержимое файлов, которые были затронуты данной операцией.

    Слабо понимаю, что здесь надо было сделать, поэтому откатился к предыдущему коммиту:

        $ git log --pretty=format:"%h %s" --graph -4
        * 5de97e5 Пункт 12.
        * 5ec39b7 Пункт 11.
        * 83262ea Пункт 10.
        * 291fdea Пункт 9.
        $ git checkout 5ec39b7
        Note: checking out '5ec39b7'.

        You are in 'detached HEAD' state. You can look around, make experimental
        changes and commit them, and you can discard any commits you make in this
        state without impacting any branches by performing another checkout.

        If you want to create a new branch to retain commits you create, you may
        do so (now or later) by using -b with the checkout command again. Example:

        git checkout -b <new-branch-name>

        HEAD is now at 5ec39b7... Пункт 11.
        
        $ git status
        HEAD detached at 5ec39b7
        nothing to commit, working tree clean

    И вернулся обратно к мастеру:

        $ git checkout master
        Previous HEAD position was 5ec39b7... Пункт 11.
        Switched to branch 'master'

    В случае если под просмотром понималось сообщение об измененных файлах препятсвующих переключению, то:

        $ git checkout master
        M       Readme.md
        Already on 'master'

    Вывод данных по последнему коммиту:

        $ git show --pretty=fuller
        commit 5de97e5077f4ff8722f1e256268e8437639b9ea0
        Author:     kleidemos <arche-kunktator@yandex.ru>
        AuthorDate: Wed Nov 30 12:27:22 2016 +0500
        Commit:     kleidemos <arche-kunktator@yandex.ru>
        CommitDate: Wed Nov 30 12:27:22 2016 +0500

            Пункт 12.

        diff --git a/Readme.md b/Readme.md
        index 45c3773..709b91f 100644
        --- a/Readme.md
        +++ b/Readme.md
        @@ -465,3 +465,76 @@
                        modified:   Readme.md

                no changes added to commit (use "git add" and/or "git commit -a")
        +
        +12.    Выполните получение версии файла из репозитария (откат, checkout). Просмотрите содержимое файлов с последними изменениями.
        +
        +    Я внес некоторые изменения в файл ExtensionChanger/Changer.fs. После чего:
        +
        +        $ git st
        +        On branch master
        +        Changes not staged for commit:
        +        (use "git add <file>..." to update what will be committed)
        +        (use "git checkout -- <file>..." to discard changes in working directory)
        +
        +                modified:   ExtensionChanger/Changer.fs
        +
        +        no changes added to commit (use "git add" and/or "git commit -a")
        +
        +    Содержимое:
        +
        +        $ cat ExtensionChanger/Changer.fs
        +        module Changer
        +
        +        open System.IO
        +
        +        let setExtension ext (directory:DirectoryInfo) =
        +            directory.GetFiles()
        +            // я "случайно" снес часть кода
        +
        +    Откат:
        +
        +        $ git checkout ExtensionChanger/Changer.fs
        +
        +    Содержимое:
        +
        +        $ cat ExtensionChanger/Changer.fs
        +        module Changer
        +
        +        open System.IO
        +
        +        let setExtension ext (directory:DirectoryInfo) =
        +            directory.GetFiles()
        +            |> Seq.iter (fun p -> File.Move(p.FullName, Path.ChangeExtension(p.FullName, ext)))
        +
        +    Не понял, какие конкретно изменения я должен был показать, поэтому вывел diff:
        +
        +        $ git diff
        +        diff --git a/Readme.md b/Readme.md
        +        index 45c3773..612c2c0 100644
        +        --- a/Readme.md
        +        +++ b/Readme.md
        +        @@ -465,3 +465,44 @@
        +                        modified:   Readme.md
        +
        +                no changes added to commit (use "git add" and/or "git commit -a")
        +        +
        +        +12.    Выполните получение версии файла из репозитария (откат, checkout). Просмотрите содержимое файлов с последними изменениями.
        +        open System.IO
        +
        +        let setExtension ext (directory:DirectoryInfo) =
        +            directory.GetFiles()
        +            |> Seq.iter (fun p -> File.Move(p.FullName, Path.ChangeExtension(p.
        FullName, ext)))
        +
        +    Не понял, какие конкретно изменения я должен был показать, поэтому вывел di
        ff:
        +
        +        $ git diff
        +        diff --git a/Readme.md b/Readme.md
        +        index 45c3773..612c2c0 100644
        +        --- a/Readme.md
        +        +++ b/Readme.md
        +        @@ -465,3 +465,44 @@
        +                        modified:   Readme.md
        +
        +                no changes added to commit (use "git add" and/or "git commit -a
        ")
        +        +
        +        +12.    Выполните получение версии файла из репозитария (откат, checkou
        t). Просмотрите содержимое файлов с последними изменениями.

14.	Выполните сравнение (просмотр различий) текущего состояния какого-либо файла с зафиксированной версией из коммита.

        $ git diff Readme.md
        diff --git a/Readme.md b/Readme.md
        index 61d8a07..90ce28b 100644
        --- a/Readme.md
        +++ b/Readme.md
        @@ -675,3 +675,4 @@
                +        +12.    Выполните получение версии файла из репозитария (откат, checkou
                t). Просмотрите содержимое файлов с последними изменениями.

        +14.    Выполните сравнение (просмотр различий) текущего состояния какого-либо файла с зафиксированной версией из коммита.

15.	Выполните клонирование любого репозитария с Github

    Пример по UWP от mcrsft:

        $ git clone "https://github.com/Microsoft/Windows-universal-samples.git"
        Cloning into 'Windows-universal-samples'...
        remote: Counting objects: 24121, done.
        remote: Compressing objects: 100% (679/679), done.
        remote: Total 24121 (delta 274), reused 0 (delta 0), pack-reused 23442
        Receiving objects: 100% (24121/24121), 23.12 MiB | 2.64 MiB/s, done.
        Resolving deltas: 100% (14032/14032), done.
        Checking connectivity... done.
        Checking out files: 100% (10186/10186), done.

16.	Создайте собственную учётную запись на Github, выполните загрузку своего репозитария на сервер. 

    Учетка была создано давно.

    Создал репозиторий на Github "ExtensionChanger". 

        $ git remote add origin https://github.com/kleidemos/ExtensionChanger.git
        $ git push origin master
        Counting objects: 54, done.
        Delta compression using up to 6 threads.
        Compressing objects: 100% (53/53), done.
        Writing objects: 100% (54/54), 14.37 KiB | 0 bytes/s, done.
        Total 54 (delta 25), reused 0 (delta 0)
        remote: Resolving deltas: 100% (25/25), done.
        To https://github.com/kleidemos/ExtensionChanger.git
        * [new branch]      master -> master
