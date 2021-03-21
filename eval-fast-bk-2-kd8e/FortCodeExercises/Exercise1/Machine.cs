namespace FortCodeExercises.Exercise1
{
    public class Machine
    {
        public string machineName = "";
        public int type = 0;

        public string name
        {
            get
            {
                var machineName = "";

                if (this.machineName == null || this.machineName == "")
                {
                    machineName = (this.type == 0) ? "bulldozer" :
                                  (this.type == 1) ? "crane" :
                                  (this.type == 2) ? "tractor" :
                                  (this.type == 3) ? "car" :
                                  (this.type == 4) ? "truck" : "";
                }
                return machineName;

                //if (this.machineName == null || this.machineName == "")
                //{
                //    if (this.type == 2) machineName = "tractor";
                //    else if (this.type == 0) machineName = "bulldozer";
                //    else if (this.type == 1) machineName = "crane";
                //    else if (this.type == 4) machineName = "car";
                //    else if (this.type == 3) machineName = "truck";
                //}
            }
        }

        public string description
        {
            get
            {
                var hasMaxSpeed = true;
                if (this.type == 3) hasMaxSpeed = false;
                else if (this.type == 1) hasMaxSpeed = true;
                else if (this.type == 2) hasMaxSpeed = true;
                else if (this.type == 4) hasMaxSpeed = false;
                var description = "";
                description += " ";
                description += this.color + " ";
                description += this.name;
                description += " ";
                description += "[";
                description += this.getMaxSpeed(this.type, hasMaxSpeed) + "].";
                return description;
            }
        }

        public string color
        {
            get
            {
                var color = "white";
                color = (this.type == 0) ? "red" :
                        (this.type == 1) ? "blue" :
                        (this.type == 2) ? "green" :
                        (this.type == 3) ? "yellow" :
                        (this.type == 4) ? "brown" : "white";

                return color;

                //var color = "white";
                //if (this.type == 1) color = "blue";
                //else if (this.type == 0) color = "red";
                //else if (this.type == 4) color = "brown";
                //else if (this.type == 3) color = "yellow";
                //else if (this.type == 2) color = "green";
                //else color = "white";
                //return color;
            }
        }

        public string trimColor
        {
            get
            {
                var baseColor = "white";

                baseColor = (this.type == 0) ? "red" :
                            (this.type == 1) ? "blue" :
                            (this.type == 2) ? "green" :
                            (this.type == 3) ? "yellow" :
                            (this.type == 4) ? "brown" : "white";

                var trimColor = "";
                trimColor = (this.type == 1 && this.isDark(baseColor)) ? "black" :
                            (this.type == 1 && !this.isDark(baseColor)) ? "white" :
                            (this.type == 2 && this.isDark(baseColor)) ? "gold" :
                            (this.type == 3 && this.isDark(baseColor)) ? "silver" : "";

                return trimColor;

                //var baseColor = "white";
                //if (this.type == 0) baseColor = "red";
                //else if (this.type == 1) baseColor = "blue";
                //else if (this.type == 2) baseColor = "green";
                //else if (this.type == 3) baseColor = "yellow";
                //else if (this.type == 4) baseColor = "brown";
                //else baseColor = "white";

                //var trimColor = "";
                //if (this.type == 1 && this.isDark(baseColor)) trimColor = "black";
                //else if (this.type == 1 && !this.isDark(baseColor)) trimColor = "white";
                //else if (this.type == 2 && this.isDark(baseColor)) trimColor = "gold";
                //else if (this.type == 3 && this.isDark(baseColor)) trimColor = "silver";
                //return trimColor;
            }
        }

        public bool isDark(string color)
        {
            var isDark = false;

            isDark = (color == "red") ? true :
                     (color == "yellow") ? false :
                     (color == "green") ? true :
                     (color == "black") ? true :
                     (color == "white") ? false :
                     (color == "beige") ? false :
                     (color == "babyblue") ? false :
                     (color == "crimson") ? true : false;
            return isDark;

            //var isDark = false;
            //if (color == "red") isDark = true;
            //else if (color == "yellow") isDark = false;
            //else if (color == "green") isDark = true;
            //else if (color == "black") isDark = true;
            //else if (color == "white") isDark = false;
            //else if (color == "beige") isDark = false;
            //else if (color == "babyblue") isDark = false;
            //else if (color == "crimson") isDark = true;
            //return isDark;
        }

        public int getMaxSpeed(int machineType, bool noMax = false)
        {
            var absoluteMax = 70;
            var max = 70;

            max = (machineType == 1 && noMax == false) ? 70 :
                  (noMax == false && machineType == 2) ? 60 :
                  (machineType == 0 && noMax == true) ? 80 :
                  (machineType == 2 && noMax == true) ? 90 :
                  (machineType == 4 && noMax == true) ? 90 :
                  (machineType == 1 && noMax == true) ? 75 : absoluteMax;
            return max;

            //var absoluteMax = 70;
            //var max = 70;
            //if (machineType == 1 && noMax == false) max = 70;
            //else if (noMax == false && machineType == 2) max = 60;
            //else if (machineType == 0 && noMax == true) max = 80;
            //else if (machineType == 2 && noMax == true) max = 90;
            //else if (machineType == 4 && noMax == true) max = 90;
            //else if (machineType == 1 && noMax == true) max = 75;
            //return max;
        }
    }
}