﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace CourseXpo
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class Expo
    {

        private modules modulesField;

        private string unlockedField;

        private string baseField;

        public Expo()
        {
            this.unlockedField = "None";
        }

        /// <remarks/>
        public modules modules
        {
            get { return this.modulesField; }
            set { this.modulesField = value; }
        }

        /// <remarks/>
        public string unlocked
        {
            get { return this.unlockedField; }
            set { this.unlockedField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
            Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string @base
        {
            get { return this.baseField; }
            set { this.baseField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class modules
    {

        private module[] moduleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Module")]
        public module[] Module
        {
            get { return this.moduleField; }
            set { this.moduleField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Module", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class module
    {

        private string nameField;

        private string descriptionField;

        private examples examplesField;

        private medias mediasField;

        private assignments assignmentsField;

        private discussions discussionsField;

        private quizzes quizzesField;

        private tests testsField;

        private string unlockAfterCompletionField;

        public module()
        {
            this.unlockAfterCompletionField = "None";
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public examples examples
        {
            get { return this.examplesField; }
            set { this.examplesField = value; }
        }

        /// <remarks/>
        public medias medias
        {
            get { return this.mediasField; }
            set { this.mediasField = value; }
        }

        /// <remarks/>
        public assignments assignments
        {
            get { return this.assignmentsField; }
            set { this.assignmentsField = value; }
        }

        /// <remarks/>
        public discussions discussions
        {
            get { return this.discussionsField; }
            set { this.discussionsField = value; }
        }

        /// <remarks/>
        public quizzes quizzes
        {
            get { return this.quizzesField; }
            set { this.quizzesField = value; }
        }

        /// <remarks/>
        public tests tests
        {
            get { return this.testsField; }
            set { this.testsField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class examples
    {

        private example[] exampleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Example")]
        public example[] Example
        {
            get { return this.exampleField; }
            set { this.exampleField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Example", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class example
    {

        private string nameField;

        private string descriptionField;

        private problemSolution problemSolutionField;

        private content contentField;

        private string unlockAfterCompletionField;

        public example()
        {
            this.unlockAfterCompletionField = "None";
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public problemSolution ProblemSolution
        {
            get { return this.problemSolutionField; }
            set { this.problemSolutionField = value; }
        }

        /// <remarks/>
        public content Content
        {
            get { return this.contentField; }
            set { this.contentField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("ProblemSolution", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class problemSolution
    {

        private problem problemField;

        private solution solutionField;

        /// <remarks/>
        public problem Problem
        {
            get { return this.problemField; }
            set { this.problemField = value; }
        }

        /// <remarks/>
        public solution Solution
        {
            get { return this.solutionField; }
            set { this.solutionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Problem", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class problem
    {

        private slides slidesField;

        /// <remarks/>
        public slides Slides
        {
            get { return this.slidesField; }
            set { this.slidesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Slides", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class slides
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(image))]
        [System.Xml.Serialization.XmlElementAttribute("links", typeof(links))]
        [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("video", typeof(video))]
        public object[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class image
    {

        private string linkField;

        /// <remarks/>
        public string link
        {
            get { return this.linkField; }
            set { this.linkField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class links
    {

        private string[] linkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public string[] link
        {
            get { return this.linkField; }
            set { this.linkField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class video
    {

        private string linkField;

        /// <remarks/>
        public string link
        {
            get { return this.linkField; }
            set { this.linkField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Solution", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class solution
    {

        private slides slidesField;

        /// <remarks/>
        public slides Slides
        {
            get { return this.slidesField; }
            set { this.slidesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Content", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class content
    {

        private slides slidesField;

        /// <remarks/>
        public slides Slides
        {
            get { return this.slidesField; }
            set { this.slidesField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class medias
    {

        private media[] mediaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Media")]
        public media[] Media
        {
            get { return this.mediaField; }
            set { this.mediaField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Media", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class media
    {

        private string nameField;

        private string descriptionField;

        private links linksField;

        private string unlockAfterCompletionField;

        public media()
        {
            this.unlockAfterCompletionField = "None";
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public links links
        {
            get { return this.linksField; }
            set { this.linksField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class assignments
    {

        private assignment[] assignmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Assignment")]
        public assignment[] Assignment
        {
            get { return this.assignmentField; }
            set { this.assignmentField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Assignment", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class assignment
    {

        private string nameField;

        private string descriptionField;

        private questions questionsField;

        private string unlockAfterCompletionField;

        public assignment()
        {
            this.unlockAfterCompletionField = "None";
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public questions questions
        {
            get { return this.questionsField; }
            set { this.questionsField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class questions
    {

        private question[] questionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Question")]
        public question[] Question
        {
            get { return this.questionField; }
            set { this.questionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Question", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class question
    {

        private string textField;

        private float valueField;

        private QuestionType questionTypeField;

        private answers answersField;

        private string correctField;

        private float timerField;

        public question()
        {
            this.valueField = ((float) (1F));
            this.questionTypeField = QuestionType.MultipleChoice;
            this.timerField = ((float) (0F));
        }

        /// <remarks/>
        public string text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }

        /// <remarks/>
        public float value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        /// <remarks/>
        public QuestionType questionType
        {
            get { return this.questionTypeField; }
            set { this.questionTypeField = value; }
        }

        /// <remarks/>
        public answers answers
        {
            get { return this.answersField; }
            set { this.answersField = value; }
        }

        /// <remarks/>
        public string correct
        {
            get { return this.correctField; }
            set { this.correctField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "0")]
        public float timer
        {
            get { return this.timerField; }
            set { this.timerField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    public enum QuestionType
    {

        /// <remarks/>
        MultipleChoice,

        /// <remarks/>
        ShortAnswer,

        /// <remarks/>
        TrueFalse,

        /// <remarks/>
        DrawDiagram,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class answers
    {

        private string[] answerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Answer")]
        public string[] Answer
        {
            get { return this.answerField; }
            set { this.answerField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class discussions
    {

        private discussion[] discussionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Discussion")]
        public discussion[] Discussion
        {
            get { return this.discussionField; }
            set { this.discussionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Discussion", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class discussion
    {

        private string nameField;

        private string descriptionField;

        private problem problemField;

        private string unlockAfterCompletionField;

        public discussion()
        {
            this.unlockAfterCompletionField = "None";
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public problem Problem
        {
            get { return this.problemField; }
            set { this.problemField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class quizzes
    {

        private quiz[] quizField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quiz")]
        public quiz[] Quiz
        {
            get { return this.quizField; }
            set { this.quizField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Quiz", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class quiz
    {

        private string nameField;

        private string descriptionField;

        private questions questionsField;

        private string unlockAfterCompletionField;

        public quiz()
        {
            this.unlockAfterCompletionField = "None";
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public questions questions
        {
            get { return this.questionsField; }
            set { this.questionsField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class tests
    {

        private test[] testField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Test")]
        public test[] Test
        {
            get { return this.testField; }
            set { this.testField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "CourseXpoSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Test", Namespace = "CourseXpoSchema", IsNullable = false)]
    public partial class test
    {

        private string nameField;

        private string descriptionField;

        private questions questionsField;

        private string unlockAfterCompletionField;

        private float timeLimitField;

        public test()
        {
            this.unlockAfterCompletionField = "None";
            this.timeLimitField = ((float) (600F));
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public questions questions
        {
            get { return this.questionsField; }
            set { this.questionsField = value; }
        }

        /// <remarks/>
        public string unlockAfterCompletion
        {
            get { return this.unlockAfterCompletionField; }
            set { this.unlockAfterCompletionField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "600")]
        public float timeLimit
        {
            get { return this.timeLimitField; }
            set { this.timeLimitField = value; }
        }
    }
}