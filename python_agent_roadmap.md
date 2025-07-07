# Python Agent Development Roadmap
## Building a Local C# Code Generator from Natural Language

### 🎯 Project Goal
Build a local Python-based agent that:
- Accepts natural language tasks from non-programmers
- Generates correct and readable C# code using predefined models (.cs DTOs)
- Respects and optionally validates output with your Irony grammar
- Works offline with frozen model memory (DTO classes) and reusable logic patterns

---

## 📍 Phase 1: Foundations & Data Collection

### Step 1.1: Sample Data Collection
- [ ] Gather 10-30 natural language explanations with corresponding C# code
- [ ] Aim for 50+ examples for better training data
- [ ] Include variety: simple queries, complex business logic, edge cases
- [ ] Document in spreadsheet or text files for initial organization

### Step 1.2: Data Structure Design
- [ ] Create JSON schema for explanation-code pairs
- [ ] Structure format:
```json
{
  "explanation": "Код знаходить програму з кодом типу страхування \"247\"...",
  "code": "__Result = \"---\";\nWorkflow.DTO.Models.Program prog = ..."
}
```
- [ ] Convert all collected samples to this JSON format
- [ ] Validate JSON structure and fix any formatting issues

### Step 1.3: DTO Model Analysis
- [ ] Collect all .cs DTO model files from your project
- [ ] Parse class definitions, properties, and method signatures
- [ ] Extract metadata: class names, property names, data types
- [ ] Map relationships between classes (inheritance, composition)

### Step 1.4: Create Frozen Model Reference
- [ ] Convert DTO analysis into structured JSON format
- [ ] Save as models.json for offline reference
- [ ] Include: class hierarchies, property types, method signatures
- [ ] Test loading and accessing model metadata

---

## 📍 Phase 2: Core Template System

### Step 2.1: Identify Common Patterns
- [ ] Analyze collected code samples for recurring patterns
- [ ] Identify common operations: GetProgramByCode, SumPlannedPayments, etc.
- [ ] Group similar logic patterns together
- [ ] Document parameter variations for each pattern

### Step 2.2: Build Template Functions
- [ ] Create Python functions for each identified pattern
- [ ] Implement GetProgramByCode() template generator
- [ ] Implement SumPlannedPayments() template generator
- [ ] Implement GetEstateAddress() template generator
- [ ] Implement CheckProgramParameter() template generator

### Step 2.3: Action Mapping System
- [ ] Create dictionary mapping action names to template functions
- [ ] Define parameter schemas for each action
- [ ] Implement parameter validation logic
- [ ] Test template generation with sample parameters

### Step 2.4: Grammar Schema Integration
- [ ] Extract or define schema from your Irony grammar
- [ ] Document allowed syntax patterns
- [ ] Create validation rules for generated code
- [ ] Test grammar compliance with sample outputs

---

## 📍 Phase 3: Natural Language Processing

### Step 3.1: Choose NLP Approach
**Option A: Rule-based NLP**
- [ ] Define regex patterns for common explanation formats
- [ ] Create keyword extraction rules
- [ ] Build parameter extraction logic
- [ ] Test with sample explanations

**Option B: LLM-assisted Processing**
- [ ] Select local model (Qwen1.5, Qwen2.5, Phi-2, Mistral)
- [ ] Install and configure model runtime (ollama, llama.cpp, vllm)
- [ ] Test model with simple code generation tasks
- [ ] Benchmark performance and accuracy

### Step 3.2: Intent Recognition System
- [ ] Build explanation → structured intent converter
- [ ] Define intent output format:
```json
{
  "action": "sum_payments_by_code",
  "parameters": {
    "insurance_code": "247"
  }
}
```
- [ ] Implement intent validation logic
- [ ] Test with various explanation styles

### Step 3.3: Code Generation Pipeline
- [ ] Accept structured intent + frozen memory (DTOs) + templates
- [ ] Implement template selection logic
- [ ] Build parameter substitution system
- [ ] Combine components into final C# code
- [ ] Test end-to-end generation pipeline

### Step 3.4: LLM Fallback System (Optional)
- [ ] Implement fallback for unmatched templates
- [ ] Design prompt template for LLM generation
- [ ] Include DTO summary and task description in prompt
- [ ] Test fallback accuracy and performance

---

## 📍 Phase 4: Validation & Quality Control

### Step 4.1: Grammar Validation Integration
- [ ] Integrate Irony grammar for syntax validation
- [ ] Parse generated C# code for syntax errors
- [ ] Implement error highlighting and reporting
- [ ] Create correction suggestions system

### Step 4.2: Code Quality Checks
- [ ] Implement basic C# syntax validation
- [ ] Check for common errors (missing semicolons, wrong chains)
- [ ] Validate DTO property access patterns
- [ ] Test with intentionally broken code samples

### Step 4.3: Output Verification System
- [ ] Create test cases for each template function
- [ ] Implement automated testing for generated code
- [ ] Add manual review checkpoints
- [ ] Document known limitations and edge cases

---

## 📍 Phase 5: User Interface & Experience

### Step 5.1: Command-Line Interface
- [ ] Build basic CLI script (agent.py)
- [ ] Implement task input handling
- [ ] Add code output saving (output.cs)
- [ ] Include basic error handling and user feedback

### Step 5.2: Memory Management System
- [ ] Load and cache DTO metadata at startup
- [ ] Implement frozen memory for available fields/methods
- [ ] Add memory persistence across sessions
- [ ] Optimize loading performance

### Step 5.3: Logging & Feedback System
- [ ] Save every explanation → code pair to build dataset
- [ ] Implement human feedback collection (✅ / ❌)
- [ ] Create logs for debugging and improvement
- [ ] Add usage statistics tracking

### Step 5.4: Enhanced Interface (Optional)
- [ ] Build Streamlit web app or Tkinter GUI
- [ ] Create textarea for explanation input
- [ ] Add C# code block output with copy button
- [ ] Implement autocompletion suggestions
- [ ] Add grammar-specific highlighting

---

## 📍 Phase 6: Advanced Features & Optimization

### Step 6.1: Local Model Fine-tuning (Optional)
- [ ] Convert example pairs to instruction-tuning format
- [ ] Prepare training data (input: explanation, output: code)
- [ ] Fine-tune selected model using Axolotl or Hugging Face
- [ ] Evaluate fine-tuned model performance

### Step 6.2: Performance Optimization
- [ ] Profile code generation pipeline
- [ ] Optimize template matching algorithms
- [ ] Improve model loading and caching
- [ ] Reduce memory footprint

### Step 6.3: Error Handling & Recovery
- [ ] Implement comprehensive error handling
- [ ] Add graceful degradation for edge cases
- [ ] Create recovery mechanisms for failed generations
- [ ] Add detailed error reporting

### Step 6.4: Production Readiness
- [ ] Add configuration management
- [ ] Implement proper logging levels
- [ ] Create deployment documentation
- [ ] Add monitoring and health checks

---

## 🎯 Success Metrics
- **Accuracy**: 80%+ of generated code compiles and runs correctly
- **Coverage**: Handles common business logic patterns in your domain
- **Usability**: Non-programmers can effectively use the tool
- **Performance**: Generates code in under 5 seconds locally
- **Reliability**: Handles edge cases gracefully

## 📚 Recommended Tech Stack
- **Core**: Python 3.8+
- **NLP**: spaCy, NLTK, or transformers
- **Local LLM**: Ollama, llama.cpp, or vllm
- **UI**: Streamlit or Tkinter
- **Grammar**: Irony.NET (via Python wrapper or subprocess)
- **Data**: JSON for model storage, SQLite for logs

## 🚀 Getting Started
1. Begin with Phase 1, Step 1.1
2. Complete each step before moving to the next
3. Test thoroughly at each phase boundary
4. Document lessons learned and adjust approach as needed