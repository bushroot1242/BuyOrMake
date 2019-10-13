using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOrBuy
{
    public class Criterion
    {
        static List<Criterion>criterions;
        private string name, description;
        public Criterion(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public static List<Criterion> getCriterions
        {
            get
            {
                return criterions;
            }
        }

        private static void generateCriterionsFirst()
        {
            criterions = new List<Criterion>();
            criterions.Add(
                new Criterion("Маржинальная рентабельность компонента",
                "Принимает значение от 5% до 150%"));
            criterions.Add(
                new Criterion("Доля чистой прибыли в маржинальной рентабельности компонента",
                "Принимает значение от 0% до 100%"));
            criterions.Add(
               new Criterion("Доля полезных затрат в постоянных издержках компонента",
               "Принимает значение от 10% до 100%"));
            criterions.Add(
               new Criterion("Поведение затрат на покупку компонента у поставщиков",
               "Баллы: 0 - дегрессивные, 1 - пропорциональные, 2 - прогрессивные."));

        }

        private static void generateCriterionsSecond()
        {
            criterions = new List<Criterion>();
            criterions.Add(
                new Criterion("Перспективы производства компонента",
                "Баллы: 0 - краткосрочные, 1 - среднесрочные, 2 - долгосрочные."));
            criterions.Add(
                new Criterion("Значимость компонента для бренда",
                "Баллы: 0 - слабая, 1 - средняя, 2 - сильная."));
            criterions.Add(
               new Criterion("Количество аутсорсеров на рынке",
               "От 1-го до 10-ти (если больше, то также выставляется значение 10)"));
            criterions.Add(
               new Criterion("Территориальное расположение аутсорсеров",
               "Баллы: 0 - зарубежные (большая часть), 1 - удалённый регион страны (большая часть), 2 - местные (большая часть)."));

        }
        private static void generateCriterionsThrid()
        {
            criterions = new List<Criterion>();
            criterions.Add(
                new Criterion("Опыт производства компонента",
                "Баллы: 0 - нет, 1 - есть, по обходным технологиям, 2 - есть, предудыщего поколения/серии, 3 - есть."));
            criterions.Add(
                new Criterion("Является ли компонент элементом, которой потребитель отключает/снимает/заменяет/ тюнингует",
                "Баллы: 0 - да, 1 - нет."));
            criterions.Add(
               new Criterion("Является ли компонент конструктивно удачным",
               "Характеристики ощутимо превышают заданных в ТЗ(на компонент или продукт целиком, хотя бы по некоторым показателям).Баллы: 0 - нет, 1 - да."));
            criterions.Add(
               new Criterion("Уровень рекламаций",
               "Баллы: 0-высокий, 1-средний, 2-слабый. При отсуствии опыта производства выставляется значение 0."));

        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
        }
    }
}
