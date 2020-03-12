using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Book
    {

        private string _forfatter;
        private int _sidetal;
        private string _isbn13;
        private string _title;

        public Book()
        {

        }

        public Book(string title, string forfatter, int sidetal, string isbn13)
        {

            _title = title;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Forfatter
        {
            get => _forfatter;
            set
            {
                if (value.Length < 2)
                {
                    _forfatter = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value >= 4 && value <= 1000)
                {
                    _sidetal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                if (value.Length == 13)
                {
                    _isbn13 = value;
                }
                else
                {
                    throw new Exception("Nope");
                }
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}, Forfatter: {Forfatter}, Sidetal: {Sidetal}, Isbn: {Isbn13}";
        }
    }
}