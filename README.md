# Hangman-VP

Проектна задача по предметот Визуелно програмирање. Изработено од:
* **Симон Ќулумов**
* **Ивана Карпузова**
* **Наташа Стојанова**

## Опис на играта „Hangman - Бесилка“

Играта е имплементација на играта Бесилка, целта е да се погодат сите букви од зборот кој е понуден.

Играчот има опција да одбере тежина на зборови (game difficulty):
* **Easy** - познати зборови - 3 минути рок за да се погоди зборот.
* **Medium** - по-непознати зборови - 2 минути рок за да се погоди зборот.
* **Hard** - ретки зборови - 1 минута рок за да се погоди зборот.

Играчот има опција да одбере категории на зборови (game categories):
* **General** - зборови од општо знаење.
* **Sport** - зборови поврзани со спорт.
* **Science** - зборови од научни гранки.
* **Movies** - зборови од филмови.
* **Geography** - зборови поврзани со географија.

Играчот губи кога ќе направи 6 грешки при погодување на збор или кога ќе му истече времето. За секоја згрешена буква се црта соодветен дел од телото на Hangmaн.
Играчот ја победува играта кога ќе ги погоди сите зборови од избраната категорија, или од сите категории.
Се чува листа од **High scores** за секоја тежина на зборови, после секое промашување на збор или гасење на играта, можете да ги видите листите на рекорди (high scores).

### Структура на играта „Hangman - Бесилка“

Играта се состои од 4 форми.

* **Нова игра** - играчот го одбира неговото име, тежина на зборови, јазик и категории. Има опција да се игра на англиски или на македонски јазик.
![alt text](https://raw.githubusercontent.com/simonqlumov/Hangman-VP/master/Screenshots/1.newgame-macedonian.png)


* **Бесилка** -  играчот го погодува зборот со кликање на буква од тастатурата на играта, или од сопствената физичка тастатура (клик на копче).
Доколку играчот сака помош може да кликне на копчето HINT / ПОМОШ, прикажани се грешни букви, категорија и тајмер.

![alt text](https://raw.githubusercontent.com/simonqlumov/Hangman-VP/master/Screenshots/5.hangman-macedonian-hint.png)


* **Инструкции** - играчот може да ги погледне инструкциите за играта.

![alt text](https://raw.githubusercontent.com/simonqlumov/Hangman-VP/master/Screenshots/4.instructions-macedonian.png)


* **Рекорди** - играчот може да ги погледне рекордите на сите што играле.

![alt text](https://raw.githubusercontent.com/simonqlumov/Hangman-VP/master/Screenshots/2.highscores-macedonian.png)


### Имлементацијата на играта „Hangman - Бесилка“

* **Збор** - јадрото на играта е зборот, класа од string-ови (име на збор и помош-hint) и Enum структури од [Game.cs](Hangman-VP/Models/Game.cs) класата.
```
public class Word {
	public string Name { get; set; }
	public string Hint { get; set; }
	public Difficulty Difficulty { get; set; }
	public Language Language { get; set; }
	public Category Category { get; set; }
}
```

* **Играч** - играчите и нивните поени (рекорди) се чуваат во Properties.Settings.Default како  List<System.Collections.Specialized.StringCollection>, па и после гасењето на играта податоците ќе бидат зачувани.
```
public class Player
{
	public string Name { get; set; }
	public int HighScore { get; set; }
	
	public override string ToString()
	{
		return $"{Name} - {HighScore}";
	}
}
```
Зачувувањето се одвива во SaveHighscore() методот во [HangmanForm.cs](Hangman-VP/HangmanForm.cs)

```
Settings.Default.EasyHighscores.Add(Game.Player.ToString());
Settings.Default.Save();
```

* **Методи** - главната играта е направена од повеќе методи, главни методи се:

- DisplayBase() - hangman-от е составен од повеќе слики, соодветната слика станува видлива кога буква ќе се згреши.
```
private void DisplayBase()
{
	BasePictureBox.ImageLocation = @"Images\base.png";
	hangmanHead.ImageLocation = @"Images\hangman-1.png";
	hangmanBody.ImageLocation = @"Images\hangman-2.png";
	hangmanLeftArm.ImageLocation = @"Images\hangman-3.png";
	hangmanRightArm.ImageLocation = @"Images\hangman-4.png";
	hangmanLeftLeg.ImageLocation = @"Images\hangman-5.png";
	hangmanRightLeg.ImageLocation = @"Images\hangman-6.png";
}
```

- LoadWords() - сите зборови се чуваат во рачно пополнета (hard-coded) листа words:
```
List<Word> Words { get; set; }
Words = new List<Word>()
{
	new Word("визуелно", "Предмет по програмирање на ФИНКИ", Difficulty.Medium, Language.Macedonian, Category.Science));
	new Word("финки", "Факултет ама без зграда", Difficulty.Easy, Language.Macedonian, Category.General));
	...
};
```
потоа се прави селекција и се зимаат зборовите според одбраните опции на играчот (difficulty, language, category).
```
 Words = words.Where(x => x.Difficulty == Game.Difficulty && x.Language == Game.Language && Game.Categories.Contains(x.Category)).ToList();
```

- GenerateDisplayWord() - Се зима рандом збор од листата и се стартува тајмер.
```
Timer.Stop();
TimeElapsed = 0;
Timer.Start();
Word = Words.ElementAt(new Random().Next(0, Words.Count));
```
потоа зборот се прикажува на екран во "Бесилка формат" = В _ З У Е _ Н О
```
 var word = Word.Name.ToUpper()[0].ToString();
 for (var i = 0; i < Word.Name.Length - 1; i++)
 {
	word += " _";
 }
WordToGuessLabel.Text = word;
```
и сите слики (делови од телото на hangman) се поставуваат невидливи
```
hangmanHead.Visible = false;
hangmanBody.Visible = false;
hangmanLeftArm.Visible = false;
hangmanRightArm.Visible = false;
hangmanLeftLeg.Visible = false;
hangmanRightLeg.Visible = false;
```
- ValidateLetter(char letter) - се повикува кога ќе се кликне копче од тастатурата, проверува дали буквата ја има во зборот
и извшува потребни функции/операции соодветно.

```
private void ValidateLetter(char letter)
{
	bool letterGuessIsCorrect = false;

	//Ибриши ги празните места од зборот.. за да дојде во форма како: u_i_e_s_ty
	string word = new string(WordToGuessLabel.Text.Where(c => !Char.IsWhiteSpace(c)).ToArray()).ToLower();
	for (int i = 0; i < Word.Name.Length; i++)
	{
		//Ако буквата кликната ја има во зборот, избриши го "_" цртичето и стави ја буквата.
		if (Word.Name[i] == letter)
		{
			letterGuessIsCorrect = true;
			word = word.Remove(i, 1);
			word = word.Insert(i, letter.ToString());
		}
	}
	
	//Ако зборот од екран е еднаков со зборот што требало да се погоди, додади поен во Highscore, избриши го зборот и генерирај нов збор
	if (Word.Name == word)
	{
		Game.Player.HighScore += 1;
		Words.Remove(Word);
		Timer.Stop();
		UpdateDisplayWord(word);
		MessageBox.Show(LanguageSettings.WordGuessCorrect, LanguageSettings.WellDoneMessage);	
		GenerateDisplayWord();
 		return;
	}
	
	//Ако буквата кликната ја нема во зборот, прикажи го hangman делот соодветно
	if (letterGuessIsCorrect == false)
	{
		++Mistakes;
		string letters = letter + ", ";
		WrongoLettersLabel.Text += letters.ToUpper();
		switch (Mistakes)
		{
			case 1:
				hangmanHead.Visible = true;
				break;
			case 2:
				hangmanBody.Visible = true;
				break;
			case 3:
				hangmanLeftArm.Visible = true;
				break;
			case 4:
				hangmanRightArm.Visible = true;
				break;
			case 5:
				hangmanLeftLeg.Visible = true;
				break;
			case 6:
				hangmanRightLeg.Visible = true;
				break;
			default:
				break;
		}
		//Ако има >= од 6 грешки, играта се губи, рекордот се зачувува и се генерира нов збор.
		if (Mistakes >= 6)
		{
			Timer.Stop();
			MessageBox.Show($"{LanguageSettings.WordGuessIncorrect}{Word.Name.ToUpper()}", LanguageSettings.YouGotHangedMessage);
			SaveHighscore();
			GenerateDisplayWord();
			return;
		}
	}
	else
	{
		UpdateDisplayWord(word);
	}
}
```

* **Повеќе јазичност** - не само што зборовите ги има на англиски и македонски, целата игра менува јазик кога бираме јазик.
Ова е направено со елиминирање на сите "magic" стрингови од кодот, и користење на static properties, вредност им задаваме на истите во зависност од јазикот кој е избран. Имплементација погледнете во [LanguageSettings.cs](Hangman-VP/LanguageSettings.cs) класата.

* **[Слики од англиска верзија](Screenshots)** 
