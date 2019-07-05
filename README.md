# Brainy-Orgasm

### Проект по Визуелно Програмирање

	Развиен од страна на:
		1. Дејан Сламков - 173036
		2. Јован Папалазоски - 173070
		3. Михаил Папалазоски - 151094


### Опис на проблемот

Едукативна апликација, промешана малку со наука и програмирање, која е составена од 3 дела кои претставуваат
3 различни теми кои ќе бидат разгледувани. Секоја од темите има 10 подтеми. Темите се следниве:
	1. Универзум - "Црна дупка", "Сонцето", "Галаксии" ...
	2. Научници -  "Алберт Ајнштајн", "Исак Њутон", "Томас Едисон" ...
	3. Програмски јазици поддржани во Visual Studio - "C#", "C++", "Python" ...

### Функционалности

Кога корисникот ќе ја стартува апликацијата, се појавува форма во која корисникот клика на некое од прикажаните
копчиња. Има избор да ги прегледа правилата на игра, поените соберени од сите корисници на апликацијата до сега и 
да ја стартува играта. Со клик на копчето "New Game", се отвара нова форма во која корисникот си го внесува името и
одбира за која тема сака да научи повеќе.

**Правила на игра:**
Се отвара форма за играта (GameForm) во која кориникот ќе се бори за информации за одбраната тема. Од горниот дел на формата ќе паѓаат објекти кои корисникот ќе треба да ги собира и да не дозволи да паднат до дното. Објектите ги собира со помош на т.н. колектор (Collector) кој е претставен со слика од темата. Со 3 пропуштени објекти корисникот губи. Секој паѓачки објект е претставуван исто од слика од подтемата на темата која кориникот претходно ја избрал. Со соберени 20 паѓачки објекти се прикажува нова форма (ContentForm) во која се прикажани слики/информации за подтемата претставена со моменталниот паѓачки објект. Секоја тема има 10 подтеми. Со зберени 200 поени играта завршува (текованта тема), со што корисникот се редиректира назад до почетната форма(MainForm) доколку сака да испроба некоја друга тема или да провери кај се рангира на листата со поени.

### Класна хиерархија

	1. Collector
	2. Content
	3. ImageBox
		a. FallingObject
	4. Game
		a. ScientistsGame
		b. UniverseGame
		c. VSGame
	5. ListImages
	6. User
	7. ShowContentException

### Форми
    1. MainForm
    2. HighScoresForm
    3. HowToPlayForm
    4. NewGameUserInput
    5. GameForm
    6. ContentForm

Дополнителни информации за класите, променливите во нив и формите се напишани во **xml summary** tags во изворниот код.

### Game.cs
```
public abstract class Game
    {
        private List<FallingObject> fallingObjects;
        protected Queue<Bitmap> pictures;
        protected Queue<Content> contents;

        public User Player { get; set; }
        public Bitmap BackgroundImage { get; set; }
        public int Speed { get; set; }
        public Color ColorOfPoints { get; set; }

        public static int WIDTH_OF_FORM;
        public static int HEIGHT_OF_FORM;

        public static Size SIZE_OF_FALLING_OBJECT = new Size(50, 50);
        public static Size SIZE_OF_COLLECTOR = new Size(100, 100);
        public static Size SIZE_OF_BACKGROUND_IMAGE;

        public static Random r = new Random();
        
        ...
        
        protected abstract void FillPicturesQueue();
        protected abstract void FillPaths();
    }
```
Оваа класа служи како координатор на GameForm формата. Во неа се чува редица од слики (**pictures**) кои се извекуваат од Recourses на проектот и кои се поврзани со темата кој корисникот ја одбрал. Game е апстракна класа, но од неа наследуваат 3 други класи кои ги репрезентираат различните теми. Има 2 апстракни методи. **Contents** редицата е редица со Content објекти кои се објекти кои содржат информации за поддтемите на темата. Овие 2 редици се полнат од двата апстракни методи во конкретните класи кои наследуваат од Game. При секои собрани 20 поени, се вадат: сликата (која ќе претставува слика за наредата поддтема) и Content објектот (информациите за тековната завршена поддтема) кои се на главата на редицата. Крајот на играта (сите поени) се сигнализира кога ќе се забележи дека **pictures** редицата е празна.

### ScientistsGame.cs
```
public class ScientistsGame : Game
    {
        public ScientistsGame(User player) : base(player)
        {
            FillPicturesQueue();
            InitializeCollector();
            ColorOfPoints = Color.Black;
            FillPaths();
        }

        protected override void FillPicturesQueue()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.lamp, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.brain, SIZE_OF_BACKGROUND_IMAGE);
            pictures.Enqueue(new Bitmap(Properties.Resources.AlbertEinstein, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.CharlesDarwin, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.IsaacNewton, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.JohannesFeynman, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.JohannesKepler, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.MarieCurie, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.NikolaTesla, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.OttoHahn, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.ThomasEdison, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.Galileo, SIZE_OF_FALLING_OBJECT));
        }

        protected override void FillPaths()
        {
            contents.Enqueue(new Content("Albert Einstein.txt", Properties.Resources.Albert1, Properties.Resources.Albert2));
            contents.Enqueue(new Content("Charles Darwin.txt", Properties.Resources.CharlesDarwin1, Properties.Resources.CharlesDarwin2));
            contents.Enqueue(new Content("Isaac Newton.txt", Properties.Resources.Newton1, Properties.Resources.Newton2));
            contents.Enqueue(new Content("Richard Feynman.txt", Properties.Resources.RichardFeynam1, Properties.Resources.RichardFeynam2));
            contents.Enqueue(new Content("Johannes Kepler.txt", Properties.Resources.JohannesKepler1, Properties.Resources.JohannesKepler2));
            contents.Enqueue(new Content("Marie Curie.txt", Properties.Resources.Marie1, Properties.Resources.Marie2));
            contents.Enqueue(new Content("Nikola Tesla.txt", Properties.Resources.Tesla1, Properties.Resources.Tesla2));
            contents.Enqueue(new Content("Otto Hahn.txt", Properties.Resources.OttoHan1, Properties.Resources.OttoHan2));
            contents.Enqueue(new Content("Thomas Edison.txt", Properties.Resources.Edison1, Properties.Resources.Edison2));
            contents.Enqueue(new Content("Galileo Galilei.txt", Properties.Resources.GalileoGalilei1, Properties.Resources.GalileoGalilei2));
        }
    }
}
```
Пример како двете редици се полнат со слики/информации за **Scientists** темата. Информациите за подтемите се зачувани во **.txt** фајлови во Contents фолдерот, од кои се читаат подоцна во **Content** класата.

### public void GameForm.UpdateDataResize()
```
    {
            int bottom = this.Height - 75;
            // the location of the life images
            life1.Location = new Point(20, bottom);
            life2.Location = new Point(life1.Location.X + life1.Width + 16, bottom);
            life3.Location = new Point(life2.Location.X + life1.Width + 16, bottom);
            // the height and width that i'm storing in the Game class
            Game.HEIGHT_OF_FORM = Height;
            Game.WIDTH_OF_FORM = Width;
            Game.SIZE_OF_BACKGROUND_IMAGE = new Size(Width, Height);
            scene.Player.Collector.UpdateDataResize();
            scene.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
            // the location of the label for points
            lblPoints.Location = new Point(Game.WIDTH_OF_FORM - 73, 15);
    }
```
Ги update - ира сите податоци афектирани од промената на големината на GameForm. Промена на големината е овозможена само со **Maximize**.

### public void Collector.UpdateDataResize()
```
        {
            minY = Game.HEIGHT_OF_FORM - 100;
            maxY = Game.HEIGHT_OF_FORM - 85;
            minX = 40;
            maxX = Game.WIDTH_OF_FORM - 70;
        }
```
Овие 4 променливи го ограничуваат колекторот да ги напушта одредени граници и зависат од големината на GameForm.

### Слики од играта
1. [MainForm](Screenshots/MainForm.png)
2. [HowToPlayForm](Screenshots/HowToPlayForm.png)
3. [UniverseMode](Screenshots/UniverseMode.png)
4. [ScientistsMode](Screenshots/ScientistsMode.png)
5. [VisualStudioMode](Screenshots/VisualStudioMode.png)
6. [ContentForm](Screenshots/ContentForm.png)