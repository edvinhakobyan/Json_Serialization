﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Json_Serialization
{
    class Company
    {
        [JsonProperty(PropertyName = "_id")]
        public string ID { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "logo")]
        public string Logo { get; set; }
        [JsonProperty(PropertyName = "about")]
        public string About { get; set; }
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }
        [JsonProperty(PropertyName = "photos")]
        public string[] Photos { get; set; }
        [JsonProperty(PropertyName = "rating")]
        public int Rating { get; set; }
        [JsonProperty(PropertyName = "billingPlan")]
        public string BillingPlan { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string ID1 { get; set; }

        public override string ToString()
        {
            return $"ID = {ID}\nName = {Name}\nDescription = {Description}\nLogo = {Logo}\nAbout = {About}\nCreated = {Created}\nRating = {Rating}\nBillingPlan = {BillingPlan}\nID1 =  {ID1}\n{new string('-', 50)}";
        }

    }




}
