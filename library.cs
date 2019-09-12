// Phrase to array of strings
string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

//Space Separator
string phrase = "The quick brown    fox     jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

// array of strings and set them with seperators instead of individual ones
string[] separatingStrings = { "<<", "..." };

string text = "one<<two......three<four";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine($"{words.Length} substrings in text:");

foreach (var word in words)
{
    System.Console.WriteLine(word);
}

// each string to a double value
using System;
using System.Globalization;

public class Example
{
   public static void Main()
   {
      string[] values = { "1,304.16", "$1,456.78", "1,094", "152",
                          "123,45 €", "1 304,16", "Ae9f" };
      double number;
      CultureInfo culture = null;

      foreach (string value in values) {
         try {
            culture = CultureInfo.CreateSpecificCulture("en-US");
            number = Double.Parse(value, culture);
            Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
         }
         catch (FormatException) {
            Console.WriteLine("{0}: Unable to parse '{1}'.",
                              culture.Name, value);
            culture = CultureInfo.CreateSpecificCulture("fr-FR");
            try {
               number = Double.Parse(value, culture);
               Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
            }
            catch (FormatException) {
               Console.WriteLine("{0}: Unable to parse '{1}'.",
                                 culture.Name, value);
            }
         }
         Console.WriteLine();
      }
   }
}
// The example displays the following output:
//    en-US: 1,304.16 --> 1304.16
//
//    en-US: Unable to parse '$1,456.78'.
//    fr-FR: Unable to parse '$1,456.78'.
//
//    en-US: 1,094 --> 1094
//
//    en-US: 152 --> 152
//
//    en-US: Unable to parse '123,45 €'.
//    fr-FR: Unable to parse '123,45 €'.
//
//    en-US: Unable to parse '1 304,16'.
//    fr-FR: 1 304,16 --> 1304.16
//
//    en-US: Unable to parse 'Ae9f'.
//    fr-FR: Unable to parse 'Ae9f'.

// Instantiates 10 copies of Prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
}

//
using UnityEngine;

public class Example : MonoBehaviour
{
    // Instantiate a rigidbody then set the velocity

    Rigidbody projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}

// Clone Scripts
using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public int timeoutDestructor;

    // ...other code...
}


public class ExampleClass : MonoBehaviour
{
    // Instantiate a Prefab with an attached Missile script
    public Missile projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Missile clone = (Missile)Instantiate(projectile, transform.position, transform.rotation);

            // Set the missiles timeout destructor to 5
            clone.timeoutDestructor = 5;
        }
    }
}
//Chapter 6: Animation

    //create variable and then access the animation that you made
    private Animator arenaAnimator

    GameObject arena = transform.parent.gameObject;
arenaAnimator = arena.GetComponent<Animator>();

    //Boolean to set off the trigger when activated
    void OnTriggerEnter(Collider other)
{
    arenaAnimator.SetBool("IsLowered", true);
}
//logic for raising a wall or something that you have in your game
void OnTriggerExit(Collider other)
{
    arenaAnimator.SetBool("IsLowered", false);
}

