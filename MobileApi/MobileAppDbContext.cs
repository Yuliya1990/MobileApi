using Microsoft.EntityFrameworkCore;
using MobileApi.Models;


namespace MobileApi
{
    public class MobileAppDbContext : DbContext
    {
        public MobileAppDbContext() { }

        public MobileAppDbContext(DbContextOptions<MobileAppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasData(
                    new City
                    {
                        Id = 1,
                        Name = "Київ",
                        Distance = 0,
                        Population = 2884000
                    },
                    new City
                    {
                        Id = 2,
                        Name = "Севастополь",
                        Distance = 1741,
                        Population = 340735
                    }, new City
                    {
                        Id = 3,
                        Name = "Сімферополь",
                        Distance = 878.1,
                        Population = 338319
                    },
                    new City
                    {
                        Id = 4,
                        Name = "Керч",
                        Distance = 1418.1,
                        Population = 144626
                    }, new City
                    {
                        Id = 5,
                        Name = "Євпаторія",
                        Distance = 1674.7,
                        Population = 107040
                    },
                    new City
                    {
                        Id = 6,
                        Name = "Вінниця",
                        Distance = 250.1,
                        Population = 369739
                    }, new City
                    {
                        Id = 7,
                        Name = "Луцьк",
                        Distance = 399.7,
                        Population = 215986
                    },
                    new City
                    {
                        Id = 8,
                        Name = "Ковель",
                        Distance = 477.2,
                        Population = 67575
                    }, new City
                    {
                        Id = 9,
                        Name = "Нововолинськ",
                        Distance = 492.3,
                        Population = 50417
                    },
                    new City
                    {
                        Id = 10,
                        Name = "Дніпро",
                        Distance = 3466,
                        Population = 968502
                    }, new City
                    {
                        Id = 11,
                        Name = "Кривий Ріг",
                        Distance = 420.1,
                        Population = 603904
                    },
                    new City
                    {
                        Id = 12,
                        Name = "Кам'янське",
                        Distance = 451.2,
                        Population = 226845
                    }, new City
                    {
                        Id = 13,
                        Name = "Нікополь",
                        Distance = 543.2,
                        Population = 105160
                    },
                    new City
                    {
                        Id = 14,
                        Name = "Павлоград",
                        Distance = 570.3,
                        Population = 101430
                    }, new City
                    {
                        Id = 15,
                        Name = "Донецьк",
                        Distance = 759.3,
                        Population = 901645
                    },
                    new City
                    {
                        Id = 16,
                        Name = "Маріуполь",
                        Distance = 841.8,
                        Population = 0
                    }, new City
                    {
                        Id = 17,
                        Name = "Житомир",
                        Distance = 140,
                        Population = 261624
                    },
                    new City
                    {
                        Id = 18,
                        Name = "Ужгород",
                        Distance = 808.7,
                        Population = 115449
                    }, new City
                    {
                        Id = 19,
                        Name = "Мукачево",
                        Distance = 770.1,
                        Population = 85569
                    },
                    new City
                    {
                        Id = 20,
                        Name = "Запоріжжя",
                        Distance = 559,
                        Population = 710052
                    }, new City
                    {
                        Id = 21,
                        Name = "Івано-Франківськ",
                        Distance = 593.7,
                        Population = 238196
                    },
                    new City
                    {
                        Id = 22,
                        Name = "Біла Церква",
                        Distance = 86.5,
                        Population = 207273
                    }, new City
                    {
                        Id = 23,
                        Name = "Кропивницький",
                        Distance = 303.1,
                        Population = 219676
                    },
                    new City
                    {
                        Id = 24,
                        Name = "Львів",
                        Distance = 540.7,
                        Population = 717273
                    }, new City
                    {
                        Id = 25,
                        Name = "Миколаїв",
                        Distance = 490.6,
                        Population = 470011
                    },
                    new City
                    {
                        Id = 26,
                        Name = "Одеса",
                        Distance = 475.4,
                        Population = 1010537
                    }, new City
                    {
                        Id = 27,
                        Name = "Полтава",
                        Distance = 351.8,
                        Population = 279593
                    },
                    new City
                    {
                        Id = 28,
                        Name = "Рівне",
                        Distance = 327.2,
                        Population = 243873
                    }, new City
                    {
                        Id = 29,
                        Name = "Суми",
                        Distance = 333.1,
                        Population = 256474
                    },
                    new City
                    {
                        Id = 30,
                        Name = "Харків",
                        Distance = 489,
                        Population = 1421125
                    }
                    );
            });
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasData(
                    new Contact
                    {
                        Id = 1,
                        Name = "Yuliia Solomakha",
                        Email = "yulichka700@gmail.com"
                    },
                    new Contact
                    {
                        Id = 2,
                        Name = "Yuliia Solomakha",
                        Email = "solomakha.yu@knu.ua"
                    },
                    new Contact
                    {
                        Id = 3,
                        Name = "Julia Nedavnyaa",
                        Email = "julka@gmail.com"
                    },
                    new Contact
                    {
                        Id = 4,
                        Name = "Dmytro Kovalenko",
                        Email = "koval@knu.ua"
                    },
                    new Contact
                    {
                        Id = 5,
                        Name = "Dmytro Aleksenko",
                        Email = "aleksenko@gmail.com"
                    },
                    new Contact
                    {
                        Id = 6,
                        Name = "Alina Bedenko",
                        Email = "alinkaa@gmail.com"
                    },
                    new Contact
                    {
                        Id = 7,
                        Name = "Vlad Burlaka",
                        Email = "takspokoyno@gmail.com"
                    },
                    new Contact
                    {
                        Id = 8,
                        Name = "Vlad Spotar",
                        Email = "vlad_sp@knu.ua"
                    },
                    new Contact
                    {
                        Id = 9,
                        Name = "Olena Rak",
                        Email = "rak_olena@knu.ua"
                    },
                    new Contact
                    {
                        Id = 10,
                        Name = "Yuliia Rak",
                        Email = "yulka@gmail.com"
                    },
                    new Contact
                    {
                        Id = 11,
                        Name = "Artem Pidgornyi",
                        Email = "pidgornyi@knu.ua"
                    }
                    );

            });
        }

    }
}
