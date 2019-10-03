// This example demonstrates the Console.Beep(Int32, Int32) method
using System;
using System.Threading;

class Sample
{
  public static void Main()
  {

    Note[] Mary =
        {
     new Note(Tone.Csharp,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.SIXTEENTH),
     new Note(Tone.AHigh,Duration.EIGHTH),
     new Note(Tone.REST,Duration.SIXTEENTH),
     new Note(Tone.Csharp,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.SIXTEENTH),
     new Note(Tone.AHigh,Duration.QUARTER),


     new Note(Tone.D,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.SIXTEENTH),
     new Note(Tone.AHigh,Duration.EIGHTH),


     new Note(Tone.D,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.SIXTEENTH),
     new Note(Tone.AHigh,Duration.QUARTER),


      new Note(Tone.B,Duration.SIXTEENTH),
     new Note(Tone.E,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.EIGHTH),
     new Note(Tone.REST,Duration.SIXTEENTH),

     new Note(Tone.B,Duration.SIXTEENTH),
     new Note(Tone.E,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.QUARTER),
     new Note(Tone.REST,Duration.SIXTEENTH),

     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.Gsharp,Duration.SIXTEENTH),
     new Note(Tone.Fsharp,Duration.SIXTEENTH),
     new Note(Tone.F,Duration.QUARTER),
        };
    // Play the song
    Play(Mary);
  }

  // Play the notes in a song.
  protected static void Play(Note[] tune)
  {
    foreach (Note n in tune)
    {
      if (n.NoteTone == Tone.REST)
        Thread.Sleep((int)n.NoteDuration);
      else
        Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
    }
  }

  // Define the frequencies of notes in an octave, as well as 
  // rest.
  protected enum Tone
  {
    REST = 0,

    Dlow = 167,

    Flow = 175,
    Glow = 196,
    A = 220,
    Asharp = 233,
    B = 247,

    // middle C
    C = 262,
    Csharp = 277,
    D = 294,
    Dsharp = 311,
    E = 330,
    F = 349,
    Fsharp = 370,
    G = 392,
    Gsharp = 415,
    AHigh = 440
  }

  // Define the duration of a note in units of milliseconds.
  protected enum Duration
  {
    WHOLE = HALF * 2,
    HALF = QUARTER * 2,
    QUARTER = 500,
    EIGHTH = QUARTER / 2,
    SIXTEENTH = EIGHTH / 2,
  }

  // Define a note as a frequency (tone) and the amount of 
  // time (duration) the note plays.
  protected struct Note
  {
    Tone toneVal;
    Duration durVal;

    // Define a constructor to create a specific note.
    public Note(Tone frequency, Duration time)
    {
      toneVal = frequency;
      durVal = time;
    }

    // Define properties to return the note's tone and duration.
    public Tone NoteTone { get { return toneVal; } }
    public Duration NoteDuration { get { return durVal; } }
  }
}
/*
This example produces the following results:

This example plays the first few notes of "Mary Had A Little Lamb" 
through the console speaker.
*/
