using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IRobot
    {
        private string model;
        private string id;
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; private set; }
        public string Id { get; private set; }
    }
}
