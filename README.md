# 🚀 Rocket Escape

## 📖 Beschrijving

Rocket Escape is een 2D survival game ontwikkeld in **Unity 6** met **C#**.

In deze game bestuurt de speler een ruimteschip en moet hij zo lang mogelijk overleven door asteroïden en vijanden te ontwijken. Tijdens het spelen verschijnen power-ups die health teruggeven. Naarmate de score stijgt, wordt de game steeds moeilijker door extra vijanden en nieuwe enemy types.

---

## 🎮 Gameplay

### Doel van het spel

Overleef zo lang mogelijk en behaal een zo hoog mogelijke score.

### Features

* Player movement
* Score systeem
* Highscore systeem
* Health systeem
* Power-up systeem
* Meerdere enemy types
* Moeilijkheidsgraad die toeneemt
* Main Menu
* Game Over systeem
* Explosion effecten
* Best Education branding

### Moeilijkheidsgraad

| Score | Verandering                                                |
| ----- | ---------------------------------------------------------- |
| 100+  | Vijanden spawnen sneller                                   |
| 500+  | Extra enemy type verschijnt                                |
| 1000+ | Spaceship enemy verschijnt en veroorzaakt direct Game Over |

---

## 🛠️ Gebruikte Technieken

### Programmeertaal

* C#

### Engine

* Unity 6

### Ontwikkelomgeving

* Visual Studio Code

### Versiebeheer

* GitHub

### Unity Functionaliteiten

* MonoBehaviour scripts
* Start() en Update()
* Collision Detection
* Scene Management
* UI systeem
* Prefabs
* PlayerPrefs
* InvokeRepeating()
* Random spawning

---

## 📦 Installatie

### Vereisten

* Unity Hub
* Unity 6

### Repository clonen

```bash
git clone [repository-url]
```

### Project openen

1. Open Unity Hub.
2. Klik op **Add Project**.
3. Selecteer de gecloneerde repository.
4. Open het project.

---

## ▶️ Game starten

1. Open het project in Unity.
2. Klik links onder op:

```text
Assets
```

3. Open:

```text
Scenes
```

4. Sleep beide scenes naar de Hierarchy:

```text
MainMenu
Game
```

5. Klik met de rechtermuisknop op:

```text
Game
```

6. Kies:

```text
Unload Scene
```

7. Controleer dat alleen **MainMenu** actief is.

8. Klik bovenaan op:

```text
Play
```

9. Klik in het hoofdmenu op:

```text
Start Game
```

om het spel te starten.

---

## 📂 Bestandsstructuur

```text
Assets
│
├── Scripts
│   ├── PlayerMovement.cs
│   ├── EnemySpawner.cs
│   ├── GameManager.cs
│   ├── HealthManager.cs
│   ├── ScoreManager.cs
│   └── MainMenu.cs
│
├── Scenes
│   ├── MainMenu.unity
│   └── Game.unity
│
├── Sprites
│
└── Audio
```

---

## 👨‍💻 Ontwikkelaar

**Alper Ayik**

Best Education

> "Wij lanceren je de toekomst in!"
