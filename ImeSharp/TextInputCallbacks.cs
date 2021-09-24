using System;
using IMEString = Microsoft.Xna.Framework.IMEString;

namespace ImeSharp
{
    public delegate void TextInputCallback(char character);
    public delegate void TextCompositionCallback(IMEString compositionText, int cursorPosition);
}
