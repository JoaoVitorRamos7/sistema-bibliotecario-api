---
name: Fix Request
about: >
    Commits que corrigem bugs, erros ou comportamentos inesperados no projeto. Exemplo: corrigir falhas no envio de formulários ou erros na paginação.
title: '[fix]:'
labels: ['fix']
assignees: []
---
## Descrição do problema

O envio de imagens maiores que 5 MB faz a aplicação travar devido a um estouro de memória.

## Passos para reproduzir

1. Acesse "Upload Image"
2. Selecione uma imagem com mais de 5 MB
3. Clique em Upload

## Comportamento esperado

A imagem deve ser enviada com sucesso ou exibir um erro caso o limite de tamanho seja excedido.

## Comportamento atual

A aplicação congela e trava após o envio de arquivos grandes.

## Plano de correção

- [ ] Adicionar validação do tamanho do arquivo no cliente
- [ ] Limitar o tamanho do buffer de upload no backend

## Ambiente

- OS: Windows 11
- Browser: Chrome v114