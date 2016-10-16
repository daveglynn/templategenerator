﻿using System;
using System.IO;
using System.Text;
 

namespace TemplateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
             
           //callGenerateApi("C:\\temp\\backend\\");
          //callGenerateClient("C:\\temp\\frontend\\");

          //callGenerateApi("C:\\SkyDrive\\Lenovo\\Olympus\\Products\\d2d\\system\\api\\v1\\api\\");
          callGenerateClient("C:\\SkyDrive\\Lenovo\\Olympus\\Products\\d2d\\system\\client-rc5\\app\\");

        }

        static void callGenerateApi(string directory)
        {
        
            callGeneratorController(directory + "controllers\\","user", "users", true);
            callGeneratorController(directory + "controllers\\", "tenant", "tenants", false);
            callGeneratorController(directory + "controllers\\", "todo", "todos", true);
            callGeneratorController(directory + "controllers\\", "order", "orders", true);
            callGeneratorController(directory + "controllers\\", "profile", "profiles", true);
            callGeneratorController(directory + "controllers\\", "list", "lists", false);
            callGeneratorController(directory + "controllers\\", "language", "languages", false);
            callGeneratorController(directory + "controllers\\", "item", "items", false);
            callGeneratorController(directory + "controllers\\", "ruleBook", "ruleBooks", false);

            callGeneratorExtension(directory + "controllers\\extensions\\", "user", "users", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "tenant", "tenants", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "todo", "todos", true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "order", "orders", true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "profile", "profiles", true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "list", "lists", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "language", "languages", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "item", "items", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "ruleBook", "ruleBooks", false);

            callGeneratorRouter(directory + "routes\\", "item", "items", false);
            callGeneratorRouter(directory + "routes\\", "language", "languages", false);
            callGeneratorRouter(directory + "routes\\", "list", "lists", false);
            callGeneratorRouter(directory + "routes\\", "order", "orders", false);
            callGeneratorRouter(directory + "routes\\", "profile", "profiles", false);
            callGeneratorRouter(directory + "routes\\", "ruleBook", "ruleBooks", false);
            callGeneratorRouter(directory + "routes\\", "tenant", "tenants", false);
            callGeneratorRouter(directory + "routes\\", "todo", "todos", false);
            callGeneratorRouter(directory + "routes\\", "user", "users", false);

        }

        static void callGenerateClient(string directory)
        {

            callGeneratorService(directory + "security\\users\\", "user", "users", false);
            callGeneratorService(directory + "security\\tenants\\", "tenant", "tenants", false);
            callGeneratorService(directory + "master\\profiles\\", "profile", "profiles", false);
            callGeneratorService(directory + "master\\languages\\", "language", "languages", false);
            callGeneratorService(directory + "master\\lists\\", "list", "lists", false);
            callGeneratorService(directory + "master\\items\\", "item", "items", false);
            callGeneratorService(directory + "master\\rulebooks\\", "ruleBook", "ruleBooks", false);

            callGeneratorConstructor(directory + "security\\users\\", "user", "users", false);
            callGeneratorConstructor(directory + "security\\tenants\\", "tenant", "tenants", false);
            callGeneratorConstructor(directory + "master\\profiles\\", "profile", "profiles", false);
            callGeneratorConstructor(directory + "master\\languages\\", "language", "languages", false);
            callGeneratorConstructor(directory + "master\\lists\\", "list", "lists", false);
            callGeneratorConstructor(directory + "master\\items\\", "item", "items", false);
            callGeneratorConstructor(directory + "master\\rulebooks\\", "ruleBook", "ruleBooks", false);

              callGeneratorRouting(directory + "security\\users\\", "user", "users", false);
         //   callGeneratorRouting(directory + "security\\tenants\\", "tenant", "tenants", false);
         //   callGeneratorRouting(directory + "master\\profiles\\", "profile", "profiles", false);
         //   callGeneratorRouting(directory + "master\\languages\\", "language", "languages", false);
         //   callGeneratorRouting(directory + "master\\lists\\", "list", "lists", false);
         //   callGeneratorRouting(directory + "master\\items\\", "item", "items", false);
         //   callGeneratorRouting(directory + "master\\rulebooks\\", "ruleBook", "ruleBooks", false);

            //callGeneratorService(directory + "todos\\", "todo", "todos", false);
            // callGeneratorService(directory + "order\\", "order", "orders", true);
            //  callGeneratorService(directory + "list\\", "list", "lists", false);
            //  callGeneratorService(directory + "item\\", "item", "items", false);
            // callGeneratorService(directory + "ruleBook\\", "ruleBook", "ruleBooks", false);

        }

        static void callGeneratorController(string directory, string singleName, string pluralName, bool tenantRequired) 
        {
            string path = @directory + singleName + ".controller.js";
            var controller = new Controller("TemplateGenerator",singleName, pluralName, tenantRequired);
            var result = controller.TransformText();
            File.WriteAllText(path, result);
        }
         static void callGeneratorExtension(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".extension.js";
            var extension = new Extension("TemplateGenerator", singleName, pluralName, tenantRequired);
            var result =   extension.TransformText();
            File.WriteAllText(path, result);
        
        }
        static void callGeneratorRouter(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".router.js";
            var Router = new Router("TemplateGenerator", singleName, pluralName, false);
            var result = Router.TransformText();
            File.WriteAllText(path, result);
        }
        static void callGeneratorService(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".service.ts";
            var service = new Service("TemplateGenerator", singleName, pluralName, false);
            var result = service.TransformText();
            File.WriteAllText(path, result);
        }
        static void callGeneratorConstructor(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".ts";
            var constructor = new Constructor("TemplateGenerator", singleName, pluralName, false);
            var result = constructor.TransformText();
            File.WriteAllText(path, result);
        }
        static void callGeneratorRouting(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + pluralName + ".routing.ts";
            var routing = new Routing("TemplateGenerator", singleName, pluralName, false);
            var result = routing.TransformText();
            File.WriteAllText(path, result);
        }

    }
}
