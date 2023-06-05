using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTextProject
{
    /*
        Создайте приложение для генерации псевдотекста.
        Пользователь вводит количество гласных и согласных,
        максимальную длину слова. Приложение генерирует текст
        на основании выбранных параметров.
    */
    internal class GenerationText
    {
        char[] vowels = "уеыаоэяию".ToCharArray();
        char[] consonants = "йцкнгшщзхъфвпрлджчсмтьб".ToCharArray();

        int countVow;
        int countConsonants;
        int maxLength;

        public GenerationText(int cV, int cC, int mL)
        {
            countConsonants = cV;
            countVow = cC;
            maxLength = mL;
        }
        public string Generation()
        {
            StringBuilder sb = new StringBuilder();
            int v = countVow, c = countConsonants;
            Random random = new Random();
            for (int i = 0; i < countVow + countConsonants; i++)
            {
                if (v-- > 0)
                {
                    sb.Append(vowels[random.Next(0, vowels.Length)]);
                }
                if (c-- > 0)
                {
                    sb.Append(consonants[random.Next(0, consonants.Length)]);
                }
            }
            AddSpace(sb);
            return sb.ToString();
        }
        private StringBuilder AddSpace(StringBuilder stringBuilder)
        {
            int indexSpace = 0;
            Random random = new Random();
            int r;
            while (indexSpace < stringBuilder.Length)
            {
                r = random.Next(1, maxLength+1);
                if (indexSpace + r <= stringBuilder.Length)
                    stringBuilder.Insert(indexSpace + r, ' ');
                indexSpace += r+1;
            }
            return stringBuilder;
        }
    }
}
