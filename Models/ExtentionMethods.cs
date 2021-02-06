using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public static class ExtentionMethods
    {
        public static string KsbDescription(this KsbKeys e)
        {
            switch (e)
            {
                case KsbKeys.SE1:
                    return "Create effective and secure software solutions using contemporary software development languages to deliver the full range of functional and non-functional requirements using relevant development methodologies.";
                case KsbKeys.SE2:
                    return "Undertake analysis and design to create artefacts, such as use cases to produce robust software designs.";
                case KsbKeys.SE3:
                    return "Produce high quality code with sound syntax in at least one language following best practices and standards.";
                case KsbKeys.SE4:
                    return "Perform code reviews, debugging and refactoring to improve code quality and efficiency.";
                case KsbKeys.SE5:
                    return "Test code to ensure that the functional and non-functional requirements have been met.";
                case KsbKeys.SE6:
                    return "Deliver software solutions using industry standard build processes, and tools for configuration management, version control and software build, release and deployment into enterprise environments.";
                case KsbKeys.SE7:
                    return "Work collaboratively and professionally with others in cross functional teams";
                case KsbKeys.SE8:
                    return "Apply secure and robust development principles to ensure software resilience";
                case KsbKeys.SE9:
                    return "How to operate at all stages of the software development lifecycle.";
                case KsbKeys.SE10:
                    return "How teams work effectively to develop software solutions embracing agile and other development approaches.";
                case KsbKeys.SE11:
                    return "How to apply software analysis and design approaches.";
                case KsbKeys.SE12:
                    return "How to interpret and implement a design, compliant with functional, non-functional and security requirements.";
                case KsbKeys.SE13:
                    return "How to perform functional and unit testing.";
                case KsbKeys.SE14:
                    return "How to use and apply the range of software tools used in software engineering.";
                case KsbKeys.SE15:
                    return "The business environment and business issues related to software development";
                case KsbKeys.C1:
                    return "Information Systems - Is able to critically analyse a business domain in order to identify the role of information systems, highlight issues and identify opportunities for improvement through evaluating information systems in relation to their intended purpose and effectiveness";
                case KsbKeys.C2:
                    return "Systems Development - Systems Development: analyses business and technical requirements to select and specify appropriate technology solutions. Designs, implements, tests, and debugs software to meet requirements using contemporary methods including agile development. Manages the development and assurance of software artefacts applying secure development practises to ensure system resilience. Configures and deploys solutions to end users.";
                case KsbKeys.C3:
                    return "Data - Identifies organisational information requirements and can model data solutions using conceptual data modelling techniques. Is able to implement a database solution using an industry standard database management system (DBMS). Can perform database administration tasks and is cognisant of the key concepts of data quality and data security. Is able to manage data effectively and undertake data analysis.";
                case KsbKeys.C4:
                    return "Cyber Security - can undertake a security risk assessment for a simple IT system and propose resolution advice. Can identify, analyse and evaluate security threats and hazards to planned and installed information systems or services (e.g. Cloud services).";
                case KsbKeys.C5:
                    return "Business Organisation - can apply organisational theory, change management, marketing, strategic practice, human resource management and IT service management to technology solutions development. Develops well-reasoned investment proposals and provides business insights.";
                case KsbKeys.C6:
                    return "IT Project Management - follows a systematic methodology for initiating, planning, executing, controlling, and closing technology solutions projects. Applies industry standard processes, methods, techniques and tools to execute projects. Is able to manage a project (typically less than six months, no inter-dependency with other projects and no strategic impact) including identifying and resolving deviations and the management of problems and escalation processes.";
                case KsbKeys.C7:
                    return "Computer and network infrastructure - can plan, design and manage computer networks with an overall focus on the services and capabilities that network infrastructure solutions enable in an organisational context. Identifies network security risks and their resolution.";
                case KsbKeys.C8:
                    return "How business exploits technology solutions for competitive advantage.";
                case KsbKeys.C9:
                    return "The value of technology investments and how to formulate a business case for a new technology solution, including estimation of both costs and benefits.";
                case KsbKeys.C10:
                    return "Contemporary techniques for design, developing, testing, correcting, deploying and documenting software systems from specifications, using agreed standards and tools.";
                case KsbKeys.C11:
                    return "How teams work effectively to produce technology solutions.";
                case KsbKeys.C12:
                    return "The role of data management systems in managing organisational data and information.";
                case KsbKeys.C13:
                    return "The various roles, functions and activities related to technology solutions within an organisation.";
                case KsbKeys.C14:
                    return "How strategic decisions are made concerning acquiring technology solutions resources and capabilities including the ability to evaluate the different sourcing options.";
                case KsbKeys.C15:
                    return "How to deliver a technology solutions project accurately consistent with business needs";
                case KsbKeys.C16:
                    return "The issues of quality, cost and time for projects, including contractual obligations and resource constraints.";
                case KsbKeys.C17:
                    return "Systems Development - Systems Development: analyses business and technical requirements to select and specify appropriate technology solutions. Designs, implements, tests, and debugs software to meet requirements using contemporary methods including agile development. Manages the development and assurance of software artefacts applying secure development practises to ensure system resilience. Configures and deploys solutions to end users.";
                case KsbKeys.C18:
                    return "Fluent in written communications and able to articulate complex issues. ";
                case KsbKeys.C19:
                    return "Makes concise, engaging and well-structured verbal presentations, arguments and explanations. ";
                case KsbKeys.C20:
                    return "Able to deal with different, competing interests within and outside the organisation with excellent negotiation skills.";
                case KsbKeys.C21:
                    return "Is able to identify the preferences, motivations, strengths and limitations of other people and apply these insights to work more effectively with and to motivate others. ";
                case KsbKeys.C22:
                    return "Competent in active listening and in leading, influencing and persuading others. ";
                case KsbKeys.C23:
                    return "Able to give and receive feedback constructively and incorporate it into his/her own development and life-long learning. ";
                case KsbKeys.C24:
                    return "Applies analytical and critical thinking skills to Technology Solutions development and to systematically analyse and apply structured problem solving techniques to complex systems and situations.";
                case KsbKeys.C25:
                    return "Able to put forward, demonstrate value and gain commitment to a moderately complex technology-oriented solution, demonstrating understanding of business need, using open questions and summarising skills and basic negotiating skills.";
                case KsbKeys.C26:
                    return "Able to conduct effective research, using literature and other media, into IT and business related topics.";
            }
            return "KSB error";
        }

        public static string GetName(this SpecialismType e)
        {
            switch (e)
            {
                case SpecialismType.SoftwareEngineering:
                    return "Software Engineering";
                case SpecialismType.BusinessAnalyst:
                    return "Business Analyst";
            }
            return "Specialism Type Error";
        }
    }
}
