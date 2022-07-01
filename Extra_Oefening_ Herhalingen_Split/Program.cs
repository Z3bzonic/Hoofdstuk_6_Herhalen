// See https://aka.ms/new-console-template for more information


using Extra_Oefening__Herhalingen_Split;

Helper helper = new Helper();
TaskSelect select = new TaskSelect();
Task0 task = new Task0();

string selectTask = select.SelectTask();
helper.StartMessage(selectTask);


