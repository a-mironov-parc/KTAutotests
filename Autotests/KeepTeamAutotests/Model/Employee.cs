using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTeamAutotests.Model
{
    public class Employee
    {
        public string login { get; set; }
        public string lastname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string birthday { get; set; }
        public string sex { get; set; }
        public string status { get; set; }
        public string employeeNumber { get; set; }
        public string nationality { get; set; }
        public string bornplace { get; set; }
        public string maritalstatus { get; set; }
        public string relation { get; set; }

        public string relLastName { get; set; }

        public string relName { get; set; }

        public string relPatronymic { get; set; }

        public string relBirthday { get; set; }

        public string relSex { get; set; }
        public string typeDoc { get; set; }
        public string seriesDoc { get; set; }
        public string dateDoc { get; set; }

        public string authorDoc {get;set;}
        public string codeDoc {get;set;}
        public string descriptionDoc{get;set;}
        
        public string arcountry { get; set; }

        public string arpostcode { get; set; }

        public string arregion { get; set; }

        public string arregistrationdate { get; set; }

        public string arcity { get; set; }

        public string arstreet { get; set; }

        public string arhouse { get; set; }

        public string arblock { get; set; }

        public string arbuilding { get; set; }

        public string arflat { get; set; }
        public string conType { get; set; }
        public string conValue { get; set; }
        public string conDescription { get; set; }

        public string typeEdu { get; set; }
        public string yearEdu { get; set; }
        public string universityEdu { get; set; }
        public string specialityEdu { get; set; }
        public string diplomaNumberEdu { get; set; }
        public string qualificationEdu { get; set; }
        public string descriptionEdu { get; set;}

        public string skillName { get; set; }
        public int skillLevel { get; set; }
        public string skillDescription { get; set; }
        public string department { get; set; }
         
       
        public override string ToString()
        {
            return "Фамилия = " + lastname + ", Имя" + name;
        }

        public void WriteToConsole()
        {
            Console.Out.WriteLine("login = "+ login);

            Console.Out.WriteLine("=============================== Основная информация ===============================");
            Console.Out.WriteLine("lastname  =                                           "+ lastname);
            Console.Out.WriteLine("name =                                                "+ name);
            Console.Out.WriteLine("patronymic  =                                         "+ patronymic);
            Console.Out.WriteLine("birthday =                                            "+ birthday);
            Console.Out.WriteLine("sex  =                                                "+ sex);
            Console.Out.WriteLine("status =                                              "+ status);
            Console.Out.WriteLine("employeeNumber  =                                     "+ employeeNumber);
            Console.Out.WriteLine("nationality =                                         "+ nationality);
            Console.Out.WriteLine("bornplace  =                                          "+ bornplace);
            Console.Out.WriteLine("maritalstatus =                                       "+ maritalstatus);

            Console.Out.WriteLine("=============================== Родственники, состав семьи ===============================");
            Console.Out.WriteLine("relation  =                                           "+ relation);
            Console.Out.WriteLine("relLastName =                                         "+ relLastName);
            Console.Out.WriteLine("relName  =                                            "+ relName);
            Console.Out.WriteLine("relPatronymic =                                       "+ relPatronymic);
            Console.Out.WriteLine("relBirthday  =                                        "+ relBirthday);
            Console.Out.WriteLine("relSex  =                                             "+ relSex);

            Console.Out.WriteLine("=============================== Документы ===============================");
            Console.Out.WriteLine("typeDoc =                                             "+ typeDoc);
            Console.Out.WriteLine("seriesDoc  =                                          "+ seriesDoc);
            Console.Out.WriteLine("dateDoc =                                             "+ dateDoc);
            Console.Out.WriteLine("authorDoc  =                                          "+ authorDoc);
            Console.Out.WriteLine("codeDoc =                                             "+ codeDoc);
            Console.Out.WriteLine("descriptionDoc  =                                     "+ descriptionDoc);

            Console.Out.WriteLine("=============================== Адрес регистрации ===============================");
            Console.Out.WriteLine("arcountry =                                           "+ arcountry);
            Console.Out.WriteLine("arpostcode =                                          "+ arpostcode);
            Console.Out.WriteLine("arregion  =                                           "+ arregion);
            Console.Out.WriteLine("arregistrationdate =                                  "+ arregistrationdate);
            Console.Out.WriteLine("arcity  =                                             "+ arcity);
            Console.Out.WriteLine("arstreet =                                            "+ arstreet);
            Console.Out.WriteLine("arhouse  =                                            "+ arhouse);
            Console.Out.WriteLine("arblock =                                             "+ arblock);
            Console.Out.WriteLine("arbuilding =                                          "+ arbuilding);
            Console.Out.WriteLine("arflat  =                                             "+ arflat);

            Console.Out.WriteLine("=============================== Контакты ===============================");
            Console.Out.WriteLine("conType =                                             "+ conType);
            Console.Out.WriteLine("conValue =                                            "+ conValue);
            Console.Out.WriteLine("conDescription  =                                     "+ conDescription);

            Console.Out.WriteLine("=============================== Образование ===============================");
            Console.Out.WriteLine("typeEdu =                                             "+ typeEdu);
            Console.Out.WriteLine("yearEdu =                                             "+ yearEdu);
            Console.Out.WriteLine("universityEdu =                                       "+ universityEdu);
            Console.Out.WriteLine("specialityEdu  =                                      "+ specialityEdu);
            Console.Out.WriteLine("diplomaNumberEdu =                                    "+ diplomaNumberEdu);
            Console.Out.WriteLine("qualificationEdu =                                    "+ qualificationEdu);
            Console.Out.WriteLine("descriptionEdu =                                      "+ descriptionEdu);
            
            
            Console.Out.WriteLine("=============================== Навыки ===============================");
            Console.Out.WriteLine("skillName =                                           "+ skillName);
            Console.Out.WriteLine("skillLevel =                                          "+ skillLevel);
            Console.Out.WriteLine("skillDescription  =                                   "+ skillDescription);

            Console.Out.WriteLine("=============================== Рабочая информация ===============================");
            Console.Out.WriteLine("department =                                           " + department);

            
        }

        
    }
}
