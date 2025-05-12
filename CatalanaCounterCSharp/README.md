CatalanaCounterCSharp
Приложение на C# для подсчёта правильных комбинаций скобок (каталонские числа).

🎯 Цель проекта
Рассчитать количество корректных комбинаций скобок для заданного количества пар.

Обработка некорректного ввода.

Быстрая работа (доступ ≤ 1 мс).

Покрытие тестами и CI-проверка через GitHub Actions.

🚀 Как запустить
Убедитесь, что установлен .NET SDK 7.0+.

Клонировать репозиторий:

bash
git clone https://github.com/ТВОЙ-Graeess/CatalanaCounterCSharp.git
cd CatalanaCounterCSharp
Сборка проекта:

bash

dotnet build
Запуск тестов:

bash
dotnet test 

Производительность
Для проверки производительности вызовите TestLoad.cs
в проекте CatalanaCounterCSharp.Tests.
В отчёте будет выведено среднее время выполнения за 15 прогонов.

📄 Про .gitignore
.gitignore настроен для исключения временных и IDE-файлов (bin/, obj/, .idea/, .vs/ и т.п.).

🧰 Стек технологий
C# / .NET 7

xUnit

GitHub Actions (CI)

JetBrains Rider / Visual Studio

⚙️ CI через GitHub Actions
В репозитории настроен GitHub Actions workflow .github/workflows/dotnet.yml,
который автоматически выполняет сборку и тестирование проекта при каждом push/pull request.

