using System;
using System.Collections.Generic;
using System.Text;

namespace PractiCode.Models
{
    public enum MenuItemType
    {
        Browse,
        CSharp,
        VisualBasic,
        FSharp,
        Java,
        Python,
        CGCC,
        CPPGCC,
        Php,
        Pascal,
        ObjectiveC,
        Haskell,
        Ruby,
        Perl,
        Lua,
        Nasm,
        SqlServer,
        JavaScript,
        Lisp,
        Prolog,
        Go,
        Scala,
        Scheme,
        Node,
        Python3,
        Octave,
        CLang,
        CPPLang,
        CPPVCPP,
        CVC,
        D,
        R,
        Tcl,
        MySql,
        PostgreSql,
        Oracle,
        TypeScript,
        Swift,
        Bash,
        Ada,
        Erlang,
        Elixir,
        Ocaml,
        Kotlin,
        Brainfuck,
        Fortran,
        Rust,
        Clojure
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
