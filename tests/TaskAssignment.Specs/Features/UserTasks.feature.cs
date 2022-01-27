﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TaskAssignment.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UserTasks")]
    public partial class UserTasksFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "UserTasks.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Features", "UserTasks", "Funcionalidade para cadastro de tarefas para usuários", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa sem título]")]
        [NUnit.Framework.CategoryAttribute("AdicionarTarefa")]
        public virtual void TarefaSemTitulo()
        {
            string[] tagsOfScenario = new string[] {
                    "AdicionarTarefa"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa sem título]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("que o título da tarefa é \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 8
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 9
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 10
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa com título pequeno]")]
        public virtual void TarefaComTituloPequeno()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa com título pequeno]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
 testRunner.Given("que o título da tarefa é \'a\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 14
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 15
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 16
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa com título grande]")]
        public virtual void TarefaComTituloGrande()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa com título grande]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
 testRunner.Given("que o título da tarefa é \'Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem I" +
                        "psum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 20
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 21
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 22
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa com título e sem descrição]")]
        public virtual void TarefaComTituloESemDescricao()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa com título e sem descrição]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.Given("que o título da tarefa é \'Título\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 26
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 27
 testRunner.And("a descrição da tarefa é \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 28
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 29
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa com título e descrição pequena]")]
        public virtual void TarefaComTituloEDescricaoPequena()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa com título e descrição pequena]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 32
 testRunner.Given("que o título da tarefa é \'Título\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 33
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 34
 testRunner.And("a descrição da tarefa é \'a\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 35
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 36
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa com estimativa pequena]")]
        public virtual void TarefaComEstimativaPequena()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa com estimativa pequena]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 39
 testRunner.Given("que o título da tarefa é \'Título\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 40
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 41
 testRunner.And("a descrição da tarefa é \'Descrição\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 42
 testRunner.And("a estimativa da tarefa é 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 43
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 44
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[Tarefa com estimativa grande]")]
        public virtual void TarefaComEstimativaGrande()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[Tarefa com estimativa grande]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
 testRunner.Given("que o título da tarefa é \'Título\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 48
 testRunner.And("o usuário da tarefa é o usuário teste", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 49
 testRunner.And("a descrição da tarefa é \'Descrição\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 50
 testRunner.And("a estimativa da tarefa é 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 51
 testRunner.When("adicionar uma tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 52
 testRunner.Then("deve ocorrer um erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
