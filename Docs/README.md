# Depra.Ecs.Baking.CodeGen

![License](https://img.shields.io/github/license/Depra-Inc/Ecs.Baking.CodeGen?style=rounded-square)
![Last Commit](https://img.shields.io/github/last-commit/Depra-Inc/Ecs.Baking.CodeGen?style=rounded-square)
![Code Size](https://img.shields.io/github/languages/code-size/Depra-Inc/Ecs.Baking.CodeGen?style=rounded-square)

<div>
    <strong><a href="README.md">English</a> | <a href="README.RU.md">Русский</a></strong>
</div>

<details>
<summary>Table of Contents</summary>

- [Introduction](#-introduction)
    - [Features](#-features)
- [Installation](#-installation)
- [Usage Examples](#-usage-examples)
- [Dependencies](#-dependencies)
- [Contributing](#-contributing)
- [Support](#-support)
- [License](#-license)

</details>

## 🧾 Introduction

**Depra.Ecs.Baking.CodeGen** is an extension for [Depra.Ecs.Baking](https://github.com/Depra-Inc/Ecs.Baking),
which introduces code generation,
making the process of creating custom components more efficient and freeing you from routine.

### 💡 Features

- **Open Source**: This library is open-source and free to use.
- **Easy to Use**: Add the `DefaultBaking` attribute to your ECS components and get ready-made `AuthoringComponent`.

## 📥 Installation

First of all you need to install [Depra.Ecs](https://github.com/Depra-Inc/Ecs.git).
Simply add the ***.dll*** to your project.

### 📦 Using **UPM**:

1. Open the **Unity Package Manager** window.
2. Click the **+** button in the upper-right corner of the window.
3. Select **Add package from git URL...**.
4. Enter the link to the [Depra.Baking repository](https://github.com/Depra-Inc/Ecs.Baking.git).
5. Click **Add**.
6. Repeat steps 2-5 for [Depra.CodeGen.Unity](https://github.com/Depra-Inc/CodeGen.Unity.git).
7. Repeat steps 2-5 for [this repository](https://github.com/Depra-Inc/Ecs.Baking.CodeGen.git).

### ⚙️ Manual:

Add the following lines to `Packages/manifest.json` in the `dependencies` section:

```
"com.depra.ecs.baking": "https://github.com/Depra-Inc/Ecs.Baking.git"
"com.depra.ecs.baking.codegen": "https://github.com/Depra-Inc/Ecs.Baking.CodeGen.git"
```

## 📋 Usage Examples

1. Add the `DefaultBaking` attribute to your **ECS** components.
2. Click `Generate Authoring Components` in the `Depra/Ecs` menu.
3. You're all set! The generated components will be located in the `Assets/Generated/AuthoringComponents` folder.

## 🖇️ Dependencies

- [Depra.Ecs](https://github.com/Depra-Inc/Ecs) - the core ECS library.
- [Depra.Ecs.Baking](https://github.com/Depra-Inc/Ecs.Baking) - a package for converting **GameObject** to **Entity**.
- [Depra.CodeGen.Unity](https://github.com/Depra-Inc/CodeGen.Unity) - a package for code generation.

## 🤝 Collaboration

I welcome feature requests and bug reports in
the [issues section](https://github.com/Depra-Inc/Ecs.Baking.CodeGen/issues),
and I also accept [pull requests](https://github.com/Depra-Inc/Ecs.Baking.CodeGen/pulls).

## 🫂 Support

I am an independent developer, and most of the development of this project is done in my free time. If you are
interested in collaborating or hiring me for a project, please check out
my [portfolio](https://github.com/Depra-Inc) and [contact me](mailto:g0dzZz1lla@yandex.ru)!

## 🔐 License

This project is distributed under the
**[Apache-2.0 license](https://github.com/Depra-Inc/Ecs.Baking.CodeGen/blob/main/LICENSE.md)**

Copyright (c) 2023 Nikolay Melnikov
[n.melnikov@depra.org](mailto:n.melnikov@depra.org)