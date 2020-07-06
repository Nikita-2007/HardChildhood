using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class Action
    {
        private List<ListUnit> ListParty;
        private ListShot listShot;
        private readonly Random random = new Random();

        //Перебор всех юнитов
        public void ActUnit(List<ListUnit> ListParty, ListShot listShot)
        {
            this.ListParty = ListParty;
            this.listShot = listShot;

            foreach (ListUnit party in ListParty)
                foreach (dynamic unit in party.listUnits)
                    if (unit.act != Act.DEAD)
                        Logic(unit);
        }

        //Логика
        public void Logic(dynamic unit)
        {
            {
                switch (unit.act)
                {
                    case Act.WAIT:
                        ActWAIT(unit);
                        break;

                    case Act.FIND:
                        ActFIND(unit);
                        break;

                    case Act.MOVE:
                        ActMOVE(unit);
                        break;

                    case Act.FIRE:
                        ActFIRE(unit);
                        break;

                    default:
                        unit.Act = Act.WAIT;
                        break;
                }
            }
        }

        //Процес ожидания
        private void ActWAIT(dynamic unit)
        {
            //Если танк мёртв
            if (unit.life <= 0)
                KillUnit(unit);

            //Если надо найти танк
            else
            {
                //Поиск ближайщего танка
                float findDelta = unit.vision, minDelta = unit.vision;
                foreach (ListUnit party in ListParty)
                    foreach (dynamic findUnit in party.listUnits)
                    {
                        if (findUnit.act != Act.DEAD && findUnit.color != unit.color)
                            findDelta = unit.Delta(unit.position, findUnit.position);
                        if (findDelta < minDelta)
                        {
                            minDelta = findDelta;
                            unit.target = findUnit.position;
                        }
                    }

                //Прверка на атаку
                if (minDelta < 512)
                {
                    unit.act = Act.FIRE;
                }

                //Проверка на движение
                else if (minDelta < 1024)
                {
                    unit.act = Act.MOVE;
                }

                //Поиск цели
                else
                {
                    unit.target.X += unit.position.X + random.Next(-128, 128);
                    unit.target.Y += unit.position.Y + random.Next(-128, 128);
                    unit.act = Act.FIND;
                }
            }
        }
        //Процес поиска
        private void ActFIND(dynamic unit)
        {
            //Юнит едит пока не найдёт цель, башня прямо
        }

        //Процес сближения
        private void ActMOVE(dynamic unit)
        {
            //Юнит едит, башня на цель, когда сможет стрелять - FIRE
            
        }

        //Процес атаки
        private void ActFIRE(dynamic unit)
        {
            unit.PositionUnit();
            unit.vector = unit.Vector(unit.vector, unit.speed);

            unit.timeShot++;
            if (unit.timeShot > 120)
            {
                listShot.NewShot(unit);
                unit.timeShot = 0;
                unit.act = Act.WAIT;
            }
        }

        //Смерть юнита
        private void KillUnit(dynamic unit)
        {
            unit.act = Act.DEAD;
            unit.speed = 0.0f;
            unit.life = 0.0f;
            unit.color = Color.Black;
        }
    }
}