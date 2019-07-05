# Brainy-Orgasm

### ������ �� �������� ������������

	������� �� ������ ��:
		1. ���� ������� - 173036
		2. ����� ����������� - 173070
		3. ������ ����������� - 151094


### ���� �� ���������

���������� ���������, ��������� ����� �� ����� � ������������, ��� � ��������� �� 3 ���� ��� �������������
3 �������� ���� ��� �� ����� ������������. ����� �� ������ ��� 10 �������. ������ �� ��������:
	1. ��������� - "���� �����", "�������", "��������" ...
	2. �������� -  "������ �������", "���� �����", "����� ������" ...
	3. ���������� ������ ��������� �� Visual Studio - "C#", "C++", "Python" ...

### ���������������

���� ���������� �� �� �������� �����������, �� ������� ����� �� ��� ���������� ����� �� ����� �� �����������
������. ��� ����� �� �� �������� ��������� �� ����, ������� �������� �� ���� ��������� �� ����������� �� ���� � 
�� �� �������� ������. �� ���� �� ������� "New Game", �� ������ ���� ����� �� ��� ���������� �� �� ������� ����� �
������ �� ��� ���� ���� �� ����� �����.

**������� �� ����:**
�� ������ ����� �� ������ (GameForm) �� ��� ��������� �� �� ���� �� ���������� �� ��������� ����. �� ������� ��� �� ������� �� ������ ������ ��� ���������� �� ����� �� �� ������ � �� �� ������� �� ������ �� �����. �������� �� ������ �� ����� �� �.�. �������� (Collector) �� � ���������� �� ����� �� ������. �� 3 ���������� ������ ���������� ����. ���� ������� ����� � ������������ ���� �� ����� �� ��������� �� ������ ��� ��������� ��������� �� ������. �� �������� 20 ������� ������ �� ��������� ���� ����� (ContentForm) �� ��� �� ��������� �����/���������� �� ��������� ����������� �� ������������ ������� �����. ����� ���� ��� 10 �������. �� ������� 200 ����� ������ �������� (��������� ����), �� ��� ���������� �� ����������� ����� �� ��������� �����(MainForm) ������� ���� �� ������� ����� ����� ���� ��� �� ������� �� �� ������� �� ������� �� �����.

### ������ ���������

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

### �����
    1. MainForm
    2. HighScoresForm
    3. HowToPlayForm
    4. NewGameUserInput
    5. GameForm
    6. ContentForm

������������ ���������� �� �������, ������������ �� ��� � ������� �� �������� �� **xml summary** tags �� ��������� ���.

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
���� ����� ����� ���� ����������� �� GameForm �������. �� ��� �� ���� ������ �� ����� (**pictures**) ��� �� ���������� �� Recourses �� �������� � ��� �� �������� �� ������ �� ���������� �� ������. Game � ��������� �����, �� �� ��� ����������� 3 ����� ����� ��� �� �������������� ���������� ����. ��� 2 ��������� ������. **Contents** �������� � ������ �� Content ������ ��� �� ������ ��� ������� ���������� �� ���������� �� ������. ���� 2 ������ �� ������ �� ����� ��������� ������ �� ����������� ����� ��� ����������� �� Game. ��� ����� ������� 20 �����, �� �����: ������� (��� �� ����������� ����� �� �������� ��������) � Content ������� (������������ �� ��������� �������� ��������) ��� �� �� ������� �� ��������. ����� �� ������ (���� �����) �� ����������� ���� �� �� �������� ���� **pictures** �������� � ������.

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
������ ���� ����� ������ �� ������ �� �����/���������� �� **Scientists** ������. ������������ �� ��������� �� �������� �� **.txt** ������ �� Contents ��������, �� ��� �� ������ ������� �� **Content** �������.

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
�� update - ��� ���� �������� ���������� �� ��������� �� ���������� �� GameForm. ������� �� ���������� � ���������� ���� �� **Maximize**.

### public void Collector.UpdateDataResize()
```
        {
            minY = Game.HEIGHT_OF_FORM - 100;
            maxY = Game.HEIGHT_OF_FORM - 85;
            minX = 40;
            maxX = Game.WIDTH_OF_FORM - 70;
        }
```
���� 4 ���������� �� ������������ ���������� �� �� ������� �������� ������� � ������� �� ���������� �� GameForm.

### ����� �� ������
1. [MainForm](Screenshots/MainForm.png)
2. [HowToPlayForm](Screenshots/HowToPlayForm.png)
3. [UniverseMode](Screenshots/UniverseMode.png)
4. [ScientistsMode](Screenshots/ScientistsMode.png)
5. [VisualStudioMode](Screenshots/VisualStudioMode.png)
6. [ContentForm](Screenshots/ContentForm.png)