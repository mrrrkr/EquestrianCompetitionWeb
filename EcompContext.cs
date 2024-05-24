using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using static EquestrianCompetitionsWebApp.Models.Test;

namespace EquestrianCompetitionsWebApp.Models;

public partial class EcompContext : DbContext
{
    public EcompContext()
    {
        NpgsqlConnection.GlobalTypeMapper.MapEnum<kind_discipline>("kind_discipline");
    }

    public EcompContext(DbContextOptions<EcompContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Competition> Competitions { get; set; }

    public virtual DbSet<CompetitionTest> CompetitionTests { get; set; }

    public virtual DbSet<CompetitionTestPerson> CompetitionTestPeople { get; set; }

    public virtual DbSet<Horse> Horses { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<SportsCouple> SportsCouples { get; set; }

    public virtual DbSet<SportsCoupleCompetition> SportsCoupleCompetitions { get; set; }

    public virtual DbSet<SportsCoupleTest> SportsCoupleTests { get; set; }

    public virtual DbSet<Sportsman> Sportsmen { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Database=ecomp;Username=postgres;Password=Korenevam250803;Persist Security Info=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("competitions", "breed", new[] { "Ахалтекинская", "Англо-норманн", "Абиссинская", "Абстанг", "Абтенайская", "Авелинская", "Австралийская пастушья", "Австралийская полукровная", "Австралийская тяжелоупряжная", "Австрийская полукровная", "Адаевская", "Азербайджанская", "Азорская", "Албанская", "Алтайская", "Альтер-реал", "Американская верховая", "Американский квотерхорс", "Американская кремовая", "Американский кучерявый башкир", "Американский пейнтхорс", "Американская стандартбредная", "Андалузская", "Англо-арабская", "Аппалуза", "Ара-Аппалуза", "Арабская", "Арденская", "Аргентинская", "Арьежуаз", "Ауксуа", "Ацтекская", "Баварская полукровная", "Балеарская", "Белорусская упряжная", "Бельгийская полукровная", "Берберийская", "Башкирская", "Битюг", "Боснийская", "Брабансон (Бельгийская рабочая)", "Бразильская спортивная", "Брамби", "Бранденбургская", "Бретонская", "Будённовская", "Булонская", "Великопольская", "Венгерская полукровная", "Вестфальская", "Владимирский тяжеловоз", "Восточноболгарская", "Вюртембергская", "Вятская", "Ганноверская", "Гафлинская", "Гидран", "Голландская", "Голштинская", "Гонтер", "Гронингенская", "Дагестанская", "Датская полукровная", "Делибоз", "Дестриэ", "Джэбе", "Донская", "Жемайтская", "Забайкальская", "Иберийская", "Ирландская спортивная", "Ирландская тяжелоупряжная", "Исландская", "Кабардинская", "Казахская", "Калмыцкая", "Камаргская", "Камполина", "Канадская", "Катхиавари", "Карабаирская", "Карабахская", "Карачаевская", "Каспийская", "Кигер-мустанг", "Кински", "Кишбер", "Киргизская", "Кладрубская", "Клейдесдаль", "Клеппер", "Кливлендская гнедая", "Крестьянская", "Кнабструпская", "Комтойс", "Коник польский", "Колорадо-рейнджер", "Креольская", "Кубинский иноходец", "Кустанайская", "Кушумская", "Латвийская", "Липпицианская", "Литовский тяжеловоз", "Локайская", "Лузитанская", "Малопольская", "Мангаларга", "Мареммано", "Марвари", "Мезенская", "Мекленбургская", "Миссурийский фокстроттер", "Монгольская", "Морган", "Мустанг", "Новоалександровская тяжелоупр", "Новоалтайская", "Новокиргизская", "Нониус", "Ольденбургская", "Орловский рысак", "Пасо-фино", "Перуанский пасо", "Першерон", "Печорская", "Пинцгауская", "Польский коник", "Польский тяжеловоз", "Португальская спортивная", "Приобская", "Русская верховая", "Русский рысак", "Русский тяжеловоз", "Керли", "Советская тяжелоупряжная", "Соррайя", "Старая фламандская", "Суффолькская", "Тавдинская", "Татарская", "Теннессийская прогулочная", "Терская", "Тракененская", "Трэйт дю Норд", "Уэльский коб", "Финская", "Флоридский крэкер", "Французский англо-араб", "Французский рысак", "Французский сель", "Фредериксборгская", "Фризская", "Фризская спортивная", "Фьордская", "Хакнэ", "Тинкер", "Чилийская", "Чистокровная верховая", "Шагия", "Шайрская", "Шварцвальдская лошадь", "Шведка", "Шленская", "Ютландская", "Эфиопская", "Якутская", "Спортивная полукровная" })
            .HasPostgresEnum("competitions", "category", new[] { "Всероссийская категория", "1 категория", "2 категория", "3 категория", "Юный судья", "" })
            .HasPostgresEnum("competitions", "color", new[] { "вороная", "серебристо-вороная", "пепельно-вороная", "гнедая", "светло-гнедая", "темно-гнедая", "олене-гнедая", "вишневая гнедая", "золотистая гнедая", "каштановая гнедая", "подласая гнедая", "караковая", "рыжая", "игнеревая", "буланая", "бурая", "соловая", "изабелловая", "серая", "светло-серая", "чалая", "саврасая", "каурая", "пегая", "чубарая", "каракулевая" })
            .HasPostgresEnum("competitions", "gender_horse", new[] { "жеребец", "мерин", "кобыла" })
            .HasPostgresEnum("competitions", "kind_discipline", new[] { "выездка", "конкур" })
            .HasPostgresEnum("competitions", "rank", new[] { "МСМК", "МС", "КМС", "1 взрослый", "2 взрослый", "3 взрослый", "1 юношеский", "2 юношеский", "3 юношеский", "б/р" });

        modelBuilder.Entity<Competition>(entity =>
        {
            entity.HasKey(e => e.IdCompetition).HasName("competition_pkey");

            entity.ToTable("competition", "competitions");

            entity.Property(e => e.IdCompetition).HasColumnName("id_competition");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.PlaceOfRealization).HasColumnName("place_of_realization");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<CompetitionTest>(entity =>
        {
            entity.HasKey(e => e.IdCompetitionTest).HasName("competition_test_pkey");

            entity.ToTable("competition_test", "competitions");

            entity.Property(e => e.IdCompetitionTest).HasColumnName("id_competition_test");
            entity.Property(e => e.IdCompetition).HasColumnName("id_competition");
            entity.Property(e => e.IdTest).HasColumnName("id_test");
            entity.Property(e => e.QuantitySportCouple).HasColumnName("quantity_sport_couple");
            entity.Property(e => e.TimeStartTest)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time_start_test");

            entity.HasOne(d => d.IdCompetitionNavigation).WithMany(p => p.CompetitionTests)
                .HasForeignKey(d => d.IdCompetition)
                .HasConstraintName("competition_test_id_competition_fkey");

            entity.HasOne(d => d.IdTestNavigation).WithMany(p => p.CompetitionTests)
                .HasForeignKey(d => d.IdTest)
                .HasConstraintName("competition_test_id_test_fkey");
        });

        modelBuilder.Entity<CompetitionTestPerson>(entity =>
        {
            entity.HasKey(e => e.IdCompetitionTestPerson).HasName("competition_test_person_pkey");

            entity.ToTable("competition_test_person", "competitions");

            entity.Property(e => e.IdCompetitionTestPerson).HasColumnName("id_competition_test_person");
            entity.Property(e => e.IdCompetitionTest).HasColumnName("id_competition_test");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");

            entity.HasOne(d => d.IdCompetitionTestNavigation).WithMany(p => p.CompetitionTestPeople)
                .HasForeignKey(d => d.IdCompetitionTest)
                .HasConstraintName("competition_test_person_id_competition_test_fkey");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.CompetitionTestPeople)
                .HasForeignKey(d => d.IdPerson)
                .HasConstraintName("competition_test_person_id_person_fkey");
        });

        modelBuilder.Entity<Horse>(entity =>
        {
            entity.HasKey(e => e.IdHorse).HasName("horse_pkey");

            entity.ToTable("horse", "competitions");

            entity.Property(e => e.IdHorse).HasColumnName("id_horse");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Father)
                .HasMaxLength(30)
                .HasColumnName("father");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.Nickname)
                .HasMaxLength(30)
                .HasColumnName("nickname");
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(40)
                .HasColumnName("place_of_birth");
            entity.Property(e => e.VeterinaryInspection).HasColumnName("veterinary_inspection");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Horses)
                .HasForeignKey(d => d.IdPerson)
                .HasConstraintName("horse_id_person_fkey");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.IdPerson).HasName("person_pkey");

            entity.ToTable("person", "competitions");

            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.FirdName)
                .HasMaxLength(30)
                .HasColumnName("fird_name");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("first_name");
            entity.Property(e => e.SecondName)
                .HasMaxLength(30)
                .HasColumnName("second_name");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasKey(e => e.IdResult).HasName("result_pkey");

            entity.ToTable("result", "competitions");

            entity.Property(e => e.IdResult).HasColumnName("id_result");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.IdCompetitionTestPerson).HasColumnName("id_competition_test_person");
            entity.Property(e => e.IdSportsCouple).HasColumnName("id_sports_couple");
            entity.Property(e => e.Letter)
                .HasMaxLength(1)
                .HasColumnName("letter");
            entity.Property(e => e.Mistakes).HasColumnName("mistakes");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.Place).HasColumnName("place");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.TechnicalMistakes).HasColumnName("technical_mistakes");

            entity.HasOne(d => d.IdCompetitionTestPersonNavigation).WithMany(p => p.Results)
                .HasForeignKey(d => d.IdCompetitionTestPerson)
                .HasConstraintName("result_id_competition_test_person_fkey");

            entity.HasOne(d => d.IdSportsCoupleNavigation).WithMany(p => p.Results)
                .HasForeignKey(d => d.IdSportsCouple)
                .HasConstraintName("result_id_sports_couple_fkey");
        });

        modelBuilder.Entity<SportsCouple>(entity =>
        {
            entity.HasKey(e => e.IdSportsCouple).HasName("sports_couple_pkey");

            entity.ToTable("sports_couple", "competitions");

            entity.Property(e => e.IdSportsCouple).HasColumnName("id_sports_couple");
            entity.Property(e => e.IdHorse).HasColumnName("id_horse");
            entity.Property(e => e.IdPerson).HasColumnName("id_person");
            entity.Property(e => e.IdSportsman).HasColumnName("id_sportsman");
            entity.Property(e => e.Standings).HasColumnName("standings");

            entity.HasOne(d => d.IdHorseNavigation).WithMany(p => p.SportsCouples)
                .HasForeignKey(d => d.IdHorse)
                .HasConstraintName("sports_couple_id_horse_fkey");

            entity.HasOne(d => d.IdPersonNavigation).WithMany(p => p.SportsCouples)
                .HasForeignKey(d => d.IdPerson)
                .HasConstraintName("sports_couple_id_person_fkey");

            entity.HasOne(d => d.IdSportsmanNavigation).WithMany(p => p.SportsCouples)
                .HasForeignKey(d => d.IdSportsman)
                .HasConstraintName("sports_couple_id_sportsman_fkey");
        });

        modelBuilder.Entity<SportsCoupleCompetition>(entity =>
        {
            entity.HasKey(e => new { e.IdSportsCouple, e.IdCompetition }).HasName("sports_couple_competition_pkey");

            entity.ToTable("sports_couple_competition", "competitions");

            entity.Property(e => e.IdSportsCouple).HasColumnName("id_sports_couple");
            entity.Property(e => e.IdCompetition).HasColumnName("id_competition");
            entity.Property(e => e.DateOfRegistration).HasColumnName("date_of_registration");

            entity.HasOne(d => d.IdCompetitionNavigation).WithMany(p => p.SportsCoupleCompetitions)
                .HasForeignKey(d => d.IdCompetition)
                .HasConstraintName("sports_couple_competition_id_competition_fkey");

            entity.HasOne(d => d.IdSportsCoupleNavigation).WithMany(p => p.SportsCoupleCompetitions)
                .HasForeignKey(d => d.IdSportsCouple)
                .HasConstraintName("sports_couple_competition_id_sports_couple_fkey");
        });

        modelBuilder.Entity<SportsCoupleTest>(entity =>
        {
            entity.HasKey(e => e.IdSportsCoupleTest).HasName("sports_couple_test_pkey");

            entity.ToTable("sports_couple_test", "competitions");

            entity.Property(e => e.IdSportsCoupleTest).HasColumnName("id_sports_couple_test");
            entity.Property(e => e.FinalPlace).HasColumnName("final_place");
            entity.Property(e => e.IdCompetition).HasColumnName("id_competition");
            entity.Property(e => e.IdSportsCouple).HasColumnName("id_sports_couple");
            entity.Property(e => e.IdTest).HasColumnName("id_test");
            entity.Property(e => e.TimeToStart)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time_to_start");

            entity.HasOne(d => d.IdTestNavigation).WithMany(p => p.SportsCoupleTests)
                .HasForeignKey(d => d.IdTest)
                .HasConstraintName("sports_couple_test_id_test_fkey");

            entity.HasOne(d => d.Id).WithMany(p => p.SportsCoupleTests)
                .HasForeignKey(d => new { d.IdSportsCouple, d.IdCompetition })
                .HasConstraintName("sports_couple_test_id_sports_couple_id_competition_fkey");
        });

        modelBuilder.Entity<Sportsman>(entity =>
        {
            entity.HasKey(e => e.IdSportsman).HasName("sportsman_pkey");

            entity.ToTable("sportsman", "competitions");

            entity.Property(e => e.IdSportsman).HasColumnName("id_sportsman");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.IdTeam).HasColumnName("id_team");
            entity.Property(e => e.MedicalCertificate).HasColumnName("medical_certificate");
            entity.Property(e => e.RegistrationNumber).HasColumnName("registration_number");
            entity.Property(e => e.SecondName)
                .HasMaxLength(20)
                .HasColumnName("second_name");

            entity.HasOne(d => d.IdTeamNavigation).WithMany(p => p.Sportsmen)
                .HasForeignKey(d => d.IdTeam)
                .HasConstraintName("sportsman_id_team_fkey");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.IdTeam).HasName("team_pkey");

            entity.ToTable("team", "competitions");

            entity.Property(e => e.IdTeam).HasColumnName("id_team");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("region");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.HasKey(e => e.IdTest).HasName("test_pkey");

            entity.ToTable("test", "competitions");

            entity.Property(e => e.IdTest).HasColumnName("id_test");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.RulesForJudging).HasColumnName("rules_for_judging");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
