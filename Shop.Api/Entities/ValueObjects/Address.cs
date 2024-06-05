using System;

namespace Shop.Api.Entities.ValueObjects
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }

        // Konstruktor
        public Address(string street, string city, string postalCode)
        {
            if (string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(postalCode))
            {
                throw new ArgumentException("Invalid address component");
            }

            Street = street;
            City = city;
            PostalCode = postalCode;
        }

        // Überschreiben der Equals Methode, um Wertgleichheit zu gewährleisten
        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   Street == address.Street &&
                   City == address.City &&
                   PostalCode == address.PostalCode;
        }

        // Überschreiben der GetHashCode Methode
        public override int GetHashCode()
        {
            return HashCode.Combine(Street, City, PostalCode);
        }

        // Optional: Überschreiben der ToString Methode
        public override string ToString()
        {
            return $"{Street}, {City}, {PostalCode}";
        }
    }
}
