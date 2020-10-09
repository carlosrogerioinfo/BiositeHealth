using System.Collections.Generic;

namespace BiositeDashBoardWeb.Contants
{
    public static class Menus
    {
        public static readonly IDictionary<string, string> controllers = new Dictionary<string, string>()
        {
            { "dashboard", "More"},
            { "ui", "UI Elements" },
            { "icon", "Icons" },
            { "forms", "Forms" },
            { "table", "Tables" },
            { "maps", "Maps" },
            { "chart", "Charts" },
            { "email", "Email" },
            { "pages", "Pages" },
            { "formulations", "Formulations" },
            { "save", "Save" }, //Apagar
            { "nutraceuticals", "Nutraceuticals" },
            { "disease", "Disease" },
            { "functionalanalysis", "FunctionalAnalysis" },
            { "register", "Register" },
            { "prescriptions", "Prescriptions" } //Apagar
        };

        public static readonly IDictionary<string, string> actions = new Dictionary<string, string>()
        {
            { "inbox", "Inbox" },
            { "email", "Email Read" },
            { "read", "Email Read" },
            { "compose", "Email Compose" },

            { "alerts", "Alerts" },
            { "buttons", "Buttons" },
            { "badges", "Badge" },
            { "cards", "Cards" },
            { "carousels", "Carousel" },
            { "dropdowns", "Dropdowns" },
            { "grid", "Grid" },
            { "images", "Images" },            
            { "lightbox", "Lightbox" },
            { "modals", "Modals" },
            { "pagination", "Pagination" },
            { "popovertooltips", "Popover & Tooltips" },
            { "progressbars", "Progress Bars" },
            { "sweetalerts", "Sweet-Alert" },
            { "tabaccordions", "Tabs & Accordions" },
            { "typography", "Typography" },
            { "video", "Video" },

            { "elements", "Forms Elements" },
            { "validation", "Forms Validation" },
            { "advanced", "Forms Advanced" },
            { "editors", "Form Editors" },
            { "uploads", "Form Upload" },
            { "xeditable", "Form Xeditable" },
                
            { "material", "Material Design" },
            { "ion", "Ion Icons" },
            { "fontawesome", "Font Awesome" },
            { "themify", "Themify Icons" },
            { "dripicons", "Dripicons" },
            { "typicons", "Typicons" },

            { "morris", "Morris Chart" },
            { "chartist", "Chartist Chart" },
            { "chartjs", "Chartjs" },
            { "flot", "Flot Chart" },
            { "c3", "C3 Chart" },
            { "other", "Jquery Knob Chart" },

            { "timeline", "Timeline" },
            { "invoice", "Invoice" },
            { "directory", "Directory" },

            { "rangeslider", "Range Slider" },
            { "sessiontimeout", "Session Timeout" },

            { "calendar", "Calendar" },

            { "basic", "Basic Tables" },
            { "datatable", "Data Tables" },
            { "responsive", "Responsive Tables" },
            { "editable", "Editable Tables" },
            { "google", "Google Maps" },
            { "vector", "Vector Maps" },

            { "prescription", "Prescrição" },
            { "register", "Registrar" },
            { "index", "Index" },
            { "create", "Create" },
            { "delete", "Delete" },
            { "edit", "Edit" },
            { "details", "Details" },
            { "information", "Informações Nutraceuticos" },
            { "prescriptions", "Prescrições" },
            { "diseaseprescriptionshow", "Disease Prescription Show" },
            { "creatediseaseprescription", "Create Disease Prescription" },
            { "editdiseaseprescription", "Edit Disease Prescription" },
            { "prescriptiondetail", "Detalhes da Prescrição" },
            { "createprescriptiondetail", "Detalhes da Prescrição Inclusão" },
            { "editprescriptiondetail", "Detalhes da Prescrição Inclusão" },


            { "blank", "Blank page"}
        };
    }
}