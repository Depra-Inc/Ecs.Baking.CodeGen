# Depra.Ecs.Baking.CodeGen

![License](https://img.shields.io/github/license/Depra-Inc/Ecs.Baking.CodeGen?style=rounded-square)
![Last Commit](https://img.shields.io/github/last-commit/Depra-Inc/Ecs.Baking.CodeGen?style=rounded-square)
![Code Size](https://img.shields.io/github/languages/code-size/Depra-Inc/Ecs.Baking.CodeGen?style=rounded-square)

<div>
    <strong><a href="README.md">English</a> | <a href="README.RU.md">Русский</a></strong>
</div>

<details>
<summary>Содержание</summary>

- [Введение](#-введение)
    - [Особенности](#-особенности)
- [Установка](#-установка)
- [Примеры использования](#-примеры-использования)
- [Зависимости](#-зависимости)
- [Сотрудничество](#-сотрудничество)
- [Поддержка](#-поддержка)
- [Лицензия](#-лицензия)

</details>

## 🧾 Введение

**Depra.Ecs.Baking.CodeGen** - расширение для [Depra.Ecs.Baking](https://github.com/Depra-Inc/Ecs.Baking),
которое внедряет кодогенерацию,
сделав процесс создания авторских компонентов более эффективным и избавив вас от рутины.

### 💡 Особенности

- **Открытый исходный код**: Эта библиотека с открытым исходным кодом и бесплатна для использования.
- **Прост в использовании**: Добавьте атрибут `DefaultBaking` к вашим компонентам и получите
  готовый `AuthoringComponent`.

## 📥 Установка

Прежде всего, вам необходимо установить [Depra.Ecs](https://github.com/Depra-Inc/Ecs.git).
Просто добавьте ***.dll*** в ваш проект.

### 📦 С использованием **UPM**:

1. Откройте окно **Unity Package Manager**.
2. Нажмите кнопку **+** в верхнем правом углу окна.
3. Выберите **Add package from git URL...**.
4. Введите [ссылку на репозиторий Depra.Baking](https://github.com/Depra-Inc/Ecs.Baking.git).
5. Нажмите **Add**.
6. Повторите шаги 2-5 для [Depra.CodeGen.Unity](https://github.com/Depra-Inc/CodeGen.Unity.git).
7. Повторите шаги 2-5 для [этого репозитория](https://github.com/Depra-Inc/Ecs.Baking.CodeGen.git).

### ⚙️ Вручную:

Добавьте следующие строки в `Packages/manifest.json` в раздел `dependencies`:

```
"com.depra.ecs.baking": "https://github.com/Depra-Inc/Ecs.Baking.git"
"com.depra.codegen": "https://github.com/Depra-Inc/CodeGen.Unity.git",
"com.depra.ecs.baking.codegen": "https://github.com/Depra-Inc/Ecs.Baking.CodeGen.git"
```

## 📋 Примеры использования

1. Добавьте атрибут `DefaultBaking` к вашим компонентам **ECS**.
2. Нажмите `Generate Authoring Components` в меню `Depra/Ecs`.
3. Вы великолепны! Сгенерированные компоненты будут лежать в папке `Assets/Generated/AuthoringComponents`.

## 🖇️ Зависимости

- [Depra.Ecs](https://github.com/Depra-Inc/Ecs) - базовая ECS библиотека.
- [Depra.Ecs.Baking](https://github.com/Depra-Inc/Ecs.Baking) - пакет для конвертации **GameObject** в **Entity**.
- [Depra.CodeGen.Unity](https://github.com/Depra-Inc/CodeGen.Unity) - пакет для кодогенерации.

## 🤝 Сотрудничество

Я рад приветствовать запросы на добавление новых функций и сообщения об ошибках
в разделе [issues](https://github.com/Depra-Inc/Ecs.Baking.CodeGen/issues)
и также принимать [pull requests](https://github.com/Depra-Inc/Ecs.Baking.CodeGen/pulls).

## 🫂 Поддержка

Я независимый разработчик, и большая часть разработки этого проекта выполняется в свободное время.
Если вы заинтересованы в сотрудничестве или найме меня для проекта,
ознакомьтесь с моим [портфолио](https://github.com/Depra-Inc)
и [свяжитесь со мной](mailto:g0dzZz1lla@yandex.ru)!

## 🔐 Лицензия

Этот проект распространяется под лицензией
**[Apache-2.0](https://github.com/Depra-Inc/Ecs.Baking.CodeGen/blob/main/LICENSE.md)**

Copyright (c) 2023 Николай Мельников
[n.melnikov@depra.org](mailto:n.melnikov@depra.org)