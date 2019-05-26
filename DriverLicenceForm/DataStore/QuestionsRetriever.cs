/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2019, Pomirleanu Ioana-Roxana,                       *
 *                         Rusu Teona-Stefana,                            *
 *                         Tucaliuc Mariana                               *
 *  Description: Proiect la Ingineria Programarii                         *
 *                                                                        *
 **************************************************************************/

using System.Collections.Generic;

namespace DataStore
{
    /// <summary>
    /// Autor: Pomirleanu Ioana-Roxana
    /// Clasa QuestionsRetriever este de tip Singleton
    /// Returneaza lista de intrebari
    /// </summary>
    public class QuestionsRetriever
    {
        #region Private Member Variables
        private static QuestionsRetriever _instance;      
        private List<Question> _questions; // datele propriu-zise ale clasei
        #endregion

        #region Constructor
        private QuestionsRetriever()
        {
            _questions = new List<Question>()
            {
                new Question(1, "Într-o zonă pietonală, semnalizată ca atare, sunteţi obligat să circulaţi cu o viteză de:",
                                "cel mult 30 km/h;",
                                "cel mult 20 km/h;",
                                "cel mult 5 km/h.",
                                "C"),
                new Question(2, "Ce măsuri se iau în cazul accidentării foarte grave a unei persoane, într-un accident de circulaţie?",
                                "transportul imediat la cea mai apropiată unitate sanitară, cu orice mijloc de transport posibil;",
                                "transportul imediat până la prima localitate şi anunţarea ambulanţei;",
                                "acordarea primului ajutor, până la sosirea ambulanţei.",
                                "C"),
                new Question(3, "În cazul unui accident cu victime şi cu deformarea accentuată a caroseriei, procedaţi la:",
                                "victimele conştiente sunt sfătuite să nu se mişte, iar degajarea acestora trebuie să se realizeze cât mai repede şi numai de către echipaje specializate;",
                                "degajarea victimelor trebuie să se realizeze cât mai repede, prin orice mijloace;",
                                "se administrează calmante victimelor care sunt conştiente.",
                                "A"),
                new Question(4, "Este permisă deţinerea, montarea sau folosirea la autovehicule a sistemelor care perturbă buna funcţionare a dispozitivelor de supraveghere a traficului?",
                                "da;",
                                "nu",
                                "acest aspect nu este stabilit legal.",
                                "B"),
                new Question(5, "Oprirea voluntară a unui vehicul este interzisă:",
                                "în zona de acţiune a indicatorului „Staţionarea interzisă“;",
                                "în curbe şi în alte locuri unde vizibilitatea este redusă sub 100 m;",
                                "în intersecţiile cu sens giratoriu.",
                                "C"),
                new Question(6, "Cum asiguraţi un autoturism cu schimbător de viteză, pentru ca acesta să nu se deplaseze din pantă?",
                                "acţionaţi frâna de serviciu;",
                                "aduceţi maneta în „punctul mort“;",
                                "introduceţi maneta într-o treaptă inferioară şi acţionaţi frâna de ajutor sau staţionare.",
                                "C"),
                new Question(7, "Aveţi obligaţia de a opri imediat autovehiculul la semnalele adresate de:",
                                "îndrumătorii de circulaţie ai Ministerului Apărării;",
                                "un conducător auto rămas în pană, pentru a-l remorca;",
                                "poliţiştii comunitari.",
                                "A"),
                new Question(8, "Încredinţarea cu ştiinţă a unui autovehicul, pentru a fi condus pe drumul public, unei persoane care nu posedă permis de conducere se pedepseşte:",
                                "penal;",
                                "contravenţional;",
                                "cu amendă contravenţională şi anularea permisului de conducere.",
                                "A"),
                new Question(9, "Acţionând o singură dată pedala de frânare, cursa acesteia este prea lungă. Acţionand de repetate ori, cursa pedalei se scurtează. Cum trebuie să procedaţi?",
                                "acţionaţi frâna mai des;",
                                "reparaţi frâna într-un atelier specializat;",
                                "nu trebuie să faceţi nimic, acest lucru este normal.",
                                "B"),
                new Question(10, "Blocarea unei roti in timpul mersului poate fi determinata de una dintre defectiunile:",
                                "ovalizarea tamburului;",
                                "griparea rulmentilor;",
                                "uzura exagerata a sabotilor.",
                                "B")
            };
        }
        #endregion

        #region Public Properties
        public List<Question> QuestionsList
        {
            get
            {
                return _questions;
            }
        }
        #endregion

        // Initializarea clasei de tip Singleton
        public static QuestionsRetriever Instance()
        {
            if(_instance == null)
            {
                _instance = new QuestionsRetriever();
            }

            return _instance;
        }
    }
}